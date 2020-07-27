using System;
using System.Text.Json;
using Student;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace _1_Карточка_студента_R
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //List<StudentDTO> students = new List<StudentDTO>();            
            StudentDTO ivan = new StudentDTO()
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
            };            
                Console.WriteLine(ivan);
            using (FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                await JsonSerializer.SerializeAsync<StudentDTO>(fs, ivan, options);

                Console.WriteLine("Сохранено в файл");
                Console.WriteLine($"{ivan.curriculum.Faculty}, {ivan.curriculum.Speciality}," +
                    $"{ ivan.curriculum.Course} { ivan.curriculum.Group}");
            }
            using (FileStream fs = new FileStream("student.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                StudentDTO student = await JsonSerializer.DeserializeAsync<StudentDTO>(fs, options);
                Console.WriteLine($"FIO: {student.FIO}, Faculty: {student.curriculum.Faculty}, Speciality: {student.curriculum.Speciality}," +
                    $" Course: {student.curriculum.Course}, Gpoup: {student.curriculum.Group}, City: {student.address.City}, PostIndex: {student.address.PostIndex}, " +
                    $"Street: {student.address.Street}, Phone: {student.contact.Phone}, Email: {student.contact.Email}");
                
            }
        }
    }
}
