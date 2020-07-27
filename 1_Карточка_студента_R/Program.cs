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
            Console.WriteLine("Начало Main");
             await StudentAsync.ReadWriteAsync();
            Console.WriteLine("Конец Main");
        }
        
        
        //static async Task Main(string[] args)
        //{
        //    StudentDTO[] students = new StudentDTO[5];    

        //    StudentDTO ivan = new StudentDTO()
        //    {
        //        FIO = "Иванов Иван Иванович",
        //        curriculum = new Сurriculum()
        //        {
        //            Faculty = "Химия",
        //            Speciality = "Органика",
        //            Course = 4,
        //            Group = "хим-бо-14-1"
        //        },
        //        address = new Address()
        //        {
        //            City = "Ставрополь",
        //            PostIndex = 355000,
        //            Street = "К. Хетагурова"
        //        },
        //        contact = new Contacts()
        //        {
        //            Phone = 89620000006,
        //            Email = "ivan@mail.ru"
        //        }
        //    };

        //    StudentDTO nik = new StudentDTO()
        //    {
        //        FIO = "Рашевский Никита Сергеевич",
        //        curriculum = new Сurriculum()
        //        {
        //            Faculty = "Химическая технолоигия",
        //            Speciality = "Переработка нефти",
        //            Course = 2,
        //            Group = "хтл-мо-18-1"
        //        },
        //        address = new Address()
        //        {
        //            City = "Ставрополь",
        //            PostIndex = 355000,
        //            Street = "Ленина"
        //        },
        //        contact = new Contacts()
        //        {
        //            Phone = 89629999999,
        //            Email = "nik@mail.ru"
        //        }
        //    };
        //    students[1] = ivan;
        //    students[2] = nik;            
        //    using (FileStream fs = new FileStream("ivan.json", FileMode.OpenOrCreate))
        //    {
        //        var options = new JsonSerializerOptions
        //        {
        //            WriteIndented = true
        //        };

        //        await JsonSerializer.SerializeAsync<StudentDTO>(fs, ivan, options);

        //        Console.WriteLine("Сохранено в файл");
        //        Console.WriteLine($"{ivan.curriculum.Faculty}, {ivan.curriculum.Speciality}," +
        //            $"{ ivan.curriculum.Course}, { ivan.curriculum.Group}");
        //        Console.WriteLine();
        //    }
        //    using (FileStream fs = new FileStream("nik.json", FileMode.OpenOrCreate))
        //    {
        //        var options = new JsonSerializerOptions
        //        {
        //            WriteIndented = true
        //        };

        //        await JsonSerializer.SerializeAsync<StudentDTO>(fs, students[2], options);

        //        Console.WriteLine("Сохранено в файл");
        //        Console.WriteLine($"{nik.curriculum.Faculty}, {nik.curriculum.Speciality}," +
        //            $"{ nik.curriculum.Course}, { nik.curriculum.Group}");
        //        Console.WriteLine();
        //    }
        //    using (FileStream fs = new FileStream("nik.json", FileMode.OpenOrCreate))
        //    {
        //        var options = new JsonSerializerOptions
        //        {
        //            WriteIndented = true
        //        };
        //        StudentDTO student = await JsonSerializer.DeserializeAsync<StudentDTO>(fs, options);// нужна ли здесь options?
        //        Console.WriteLine($"FIO: {student.FIO},\n Curriculum\nFaculty: {student.curriculum.Faculty},\nSpeciality: {student.curriculum.Speciality},\n" +
        //            $"Course: {student.curriculum.Course},\nGpoup: {student.curriculum.Group},\n Address\nCity: {student.address.City},\nPostIndex: {student.address.PostIndex},\n" +
        //            $"Street: {student.address.Street},\n Contact\nPhone: {student.contact.Phone},\nEmail: {student.contact.Email}");
                
        //    }
        //}
    }
}
