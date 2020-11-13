using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class DeserializeStudents
{
  static void Main()
  {
    // read the two students saved earlier back from the disk
    FileStream stream = new FileStream("students.dat",
                                       FileMode.Open);
    BinaryFormatter formatter = new BinaryFormatter();
 
    Student student1 = (Student)formatter.Deserialize(stream);
    Console.WriteLine("Read a Student: {0}", student1);
    
    Student student2 = (Student)formatter.Deserialize(stream);
    Console.WriteLine("Read a Student: {0}", student2);
    
    stream.Close();
  }
}