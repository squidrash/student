using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace Student
{
    public class StudentAsync
    {
         public static async Task ReadWriteAsync()
         {
            List<StudentDTO> students = new List<StudentDTO>();
            students.Add(new StudentDTO()
            {
                FIO = "Иванов Иван Иванович",
                curriculum = new Сurriculum()
                {
                    Faculty = "Химия",
                    Speciality = "Органика",
                    Course = 4,
                    Group = "хим-бо-14-1"
                },
                address = new Address()
                {
                    City = "Ставрополь",
                    PostIndex = 355000,
                    Street = "К. Хетагурова"
                },
                contact = new Contacts()
                {
                    Phone = 89620000006,
                    Email = "ivan@mail.ru"
                }
            });
            students.Add(new StudentDTO()
            {
                FIO = "Рашевский Никита Сергеевич",
                curriculum = new Сurriculum()
                {
                    Faculty = "Химическая технология",
                    Speciality = "Переработка нефти",
                    Course = 2,
                    Group = "хтл-мо-18-1"
                },
                address = new Address()
                {
                    City = "Ставрополь",
                    PostIndex = 355000,
                    Street = "Ленина"
                },
                contact = new Contacts()
                {
                    Phone = 89629999999,
                    Email = "nik@mail.ru"
                }
            });
            StudentDTO ivan = students[0];
            StudentDTO nik = students[1];
            foreach (StudentDTO s in students)
            {
                Console.WriteLine(s.FIO);
            }

            using (FileStream fs = new FileStream("ivan.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                await JsonSerializer.SerializeAsync<StudentDTO>(fs, ivan, options);

                Console.WriteLine("Сохранено в файл");
                Console.WriteLine($"{ivan.curriculum.Faculty}, {ivan.curriculum.Speciality}," +
                    $"{ ivan.curriculum.Course}, { ivan.curriculum.Group}");
                Console.WriteLine();
            }
            using (FileStream fs = new FileStream("nik.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                await JsonSerializer.SerializeAsync<StudentDTO>(fs, nik, options);

                Console.WriteLine("Сохранено в файл");
                Console.WriteLine($"{nik.curriculum.Faculty}, {nik.curriculum.Speciality}," +
                    $"{ nik.curriculum.Course}, { nik.curriculum.Group}");
                Console.WriteLine();
            }
            using (FileStream fs = new FileStream("nik.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                StudentDTO student = await JsonSerializer.DeserializeAsync<StudentDTO>(fs, options);// нужна ли здесь options?
                Console.WriteLine($"FIO: {student.FIO},\n Curriculum\nFaculty: {student.curriculum.Faculty},\nSpeciality: {student.curriculum.Speciality},\n" +
                    $"Course: {student.curriculum.Course},\nGpoup: {student.curriculum.Group},\n Address\nCity: {student.address.City},\nPostIndex: {student.address.PostIndex},\n" +
                    $"Street: {student.address.Street},\n Contact\nPhone: {student.contact.Phone},\nEmail: {student.contact.Email}");

            }
         }
    }
}
