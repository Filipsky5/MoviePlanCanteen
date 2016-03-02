using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void WorkerValidatorTest()
        {
            DesignPattern.Worker worker = new DesignPattern.Worker()
            {
                Age = 18,
                Role = DesignPattern.RoleType.Camerman
            };
            DesignPattern.WorkerValidator validator = new DesignPattern.WorkerWorkValidator();


            Assert.IsFalse(validator.validate(worker));
        }

        [TestMethod]

        public void WorkerValidatorTestIsActor()
        {
            DesignPattern.Worker worker = new DesignPattern.Worker()
            {
                Age = 18,
                Role = DesignPattern.RoleType.Actor
            };
            DesignPattern.WorkerValidator validator = new DesignPattern.WorkerWorkValidator();


            Assert.IsTrue(validator.validate(worker));
        }

        [TestMethod]
        public void WorkerAgeValidatorTest()
        {
            DesignPattern.Worker worker = new DesignPattern.Worker()
            {
                Age = 18,
                Role = DesignPattern.RoleType.Actor
            };
            DesignPattern.WorkerValidator validator = new DesignPattern.WorkerAgeValidator();
            Assert.IsTrue(validator.validate(worker));
        }

        [TestMethod]
        public void WorkerAgeValidatorTestForYounger()
        {
            DesignPattern.Worker worker = new DesignPattern.Worker()
            {
                Age = 12,
                Role = DesignPattern.RoleType.Actor
            };
            DesignPattern.WorkerValidator validator = new DesignPattern.WorkerAgeValidator();
            Assert.IsFalse(validator.validate(worker));
        }
    }
}
