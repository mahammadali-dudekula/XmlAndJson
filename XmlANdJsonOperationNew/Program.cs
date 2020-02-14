using System;
using System.Collections.Generic;
using XmlANdJsonOperationNew.Entity;
using XmlANdJsonOperationNew.Provider;

namespace XmlANdJsonOperationNew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Details //

            Student st = new Student();
            st.Name = "Mahammad ali";
            st.Age = 21;
            Student st1 = new Student();
            st1.Name = "Dillip";
            st1.Age = 22;
            List<Student> list = new List<Student>();
            list.Add(st);
            list.Add(st1);
            StudentList studentList = new StudentList();
            studentList.AllStudent = list.ToArray();
            StudentProviderXml providerXml = new StudentProviderXml();
            providerXml.Serialization(studentList);
            providerXml.Deserialization();
            Console.WriteLine("Student Desirializer Output: ");
            foreach (var item in studentList.AllStudent)
            {
                Console.WriteLine($"Name :{item.Name}");
                Console.WriteLine($"Age  :{item.Age}");
            }

            //Employee Details//

            Employee employee = new Employee();
            employee.Name = "Ali chotu";
            employee.Salery = 40000;

            Employee employee1 = new Employee();
            employee1.Name = "Thulasi";
            employee1.Salery = 50000;
            List<Employee> list1 = new List<Employee>();
            list1.Add(employee);
            list1.Add(employee1);
            EmployeeList employeeList = new EmployeeList();
            employeeList.AllEmployees = list1.ToArray();
            EmployeeProviderXml xml = new EmployeeProviderXml();
            xml.EmployeeSerialization(employeeList);
            xml.Deserialization();
            Console.WriteLine("Employee Desirializer Output: ");
            foreach (var item in employeeList.AllEmployees)
            {
                Console.WriteLine($"Name    :{item.Name}");
                Console.WriteLine($"Salery  :{item.Salery}");
            }

            // All Data  // using Generics
            
            AllData<Student> allData = new AllData<Student>();
            allData.Data = list;
            GenericProvider<Student> generic = new GenericProvider<Student>();
            generic.Serialization(allData,"MyDetailsGeneric.xml");
            Console.WriteLine("Generic DeSerilization output: ");
            generic.Deserialization("MyDetailsGeneric.xml");
            foreach (var item in allData.Data)
            {
                Console.WriteLine($"Name :{item.Name}");
                Console.WriteLine($"Age :{item.Age}");
            }


            //json Student//
            StudentProviderJson providerJson = new StudentProviderJson();
            providerJson.SerializeData(studentList);
            providerJson.DeserializeStudent();
            Console.WriteLine("StudentjsonDeserialze: ");
            foreach (var item in allData.Data)
            {
                Console.WriteLine($"Name :{item.Name}");
                Console.WriteLine($"Age :{item.Age}");
            }
            //json Employee//
            AllData<Employee> allData1 = new AllData<Employee>();
            allData1.Data = list1;
            EmployeeProviderjson providerjson = new EmployeeProviderjson();
            providerjson.SerializeData(employeeList);
            providerjson.DeserializeEmployee();
            Console.WriteLine("EmployeejsonDeserialze: ");
            foreach (var item in allData1.Data)
            {
                Console.WriteLine($"Name :{item.Name}");
                Console.WriteLine($"Age  :{item.Salery}");
            }

            //json using Generic//
            AllData<Employee> allData2 = new AllData<Employee>();
            allData2.Data = list1;
            GenericProviderJson<Employee> providerJson1 = new GenericProviderJson<Employee>();
            providerJson1.SerializeDataGeneric(allData2, "MyEmployee.json");
            providerJson1.DeserializeStudentGEneric("MyEmployee.json");
            Console.WriteLine("JenericEmployeejSon: ");
            foreach (var item in allData2.Data)
            {
                Console.WriteLine($"Name :{item.Name}");
                Console.WriteLine($"Age  :{item.Salery}");
            }
        }
    }
}
