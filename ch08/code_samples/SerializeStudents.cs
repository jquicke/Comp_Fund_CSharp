using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Writes two students to disk using serialization.
class SerializeStudents
{
  static void Main()
  {
    Student student1 = new Student("Billy Bob", 1234, 2.0);
    Student student2 = new Student("Jimmy Ray", 5678, 3.1);
    
    FileStream stream = new FileStream("students.dat",
                                       FileMode.Create);
    BinaryFormatter formatter = new BinaryFormatter();

    // serialize them
    Console.WriteLine("Writing Student: {0}", student1);
    formatter.Serialize(stream, student1);

    Console.WriteLine("Writing Student: {0}", student2);
    formatter.Serialize(stream, student2);

    stream.Close();
    
    // wipe out the variables to show the deserialization works
    student1 = null;
    student2 = null;
    
    // read the two students back from the disk (deserialize)
    Console.WriteLine();
    stream = new FileStream("students.dat", FileMode.Open);

    student1 = (Student)formatter.Deserialize(stream);
    Console.WriteLine("Read a Student: {0}", student1);
    
    student2 = (Student)formatter.Deserialize(stream);
    Console.WriteLine("Read a Student: {0}", student2);
    
    stream.Close();
  }
}