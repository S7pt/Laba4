using _4._1.models;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
          Student student1=new Student();
          Student student2=new Student();
          Student student3=new Student();
          student1.setRating(95);
          student2.setRating(39);
          student3.setRating(75);
          string student1Message=student1.studentRating(student1.getRating());
          string student2Message = student2.studentRating(student2.getRating());
          string student3Message = student3.studentRating(student3.getRating());
          Assert.AreEqual("Greet the excellent student",student1Message);
          Assert.AreEqual("You should spend more time studying",student2Message);
          Assert.AreEqual("You can study better",student3Message);
        }
    }
}