using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class SerializeObjects
{
  static void Main()
  {
    // serialize two objects
    FileStream stream = new FileStream("objects.dat",
                                       FileMode.Create);
    BinaryFormatter formatter = new BinaryFormatter();
    formatter.Serialize(stream,
      new Student("Billy Bob", 1234, 2.0));
    formatter.Serialize(stream, new BankAccount("Jethro", 50.0));
    stream.Close();

    // try to deserialize the objects (in the wrong order)
    stream = new FileStream("objects.dat", FileMode.Open);
    BankAccount jethro = (BankAccount)formatter.Deserialize(stream);
    Student billy = (Student)formatter.Deserialize(stream);
  }
}