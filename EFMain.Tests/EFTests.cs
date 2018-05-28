using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EFMain.Tests
{
    [TestFixture]
    public class EFTests
    {
        [Test]
        public void CanIntitalizaDatabase()
        {
            using (var context = new MyDbContext())
            {
                context.MyEntities.ToList();
            }

            Assert.Inconclusive("If we're here, it did not crash");
        }
    }
}
