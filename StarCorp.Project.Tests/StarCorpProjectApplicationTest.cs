using NUnit.Framework;
using StarCorp.Project.Application;

namespace Tests
{
    public class StarCorpProjectApplicationTest
    {
        private IStarCorpProjectApplication _starCorpProjectApplication;

        [Test]
        public void Caculate_Multiple_3()
        {
            _starCorpProjectApplication = new StarCorpProjectApplication();
            var ret = _starCorpProjectApplication.Calculate(3);
            Assert.AreEqual(ret, "StarCorp");            
        }
        [Test]
        public void Caculate_Multiple_5()
        {
            _starCorpProjectApplication = new StarCorpProjectApplication();
            var ret = _starCorpProjectApplication.Calculate(5);
            Assert.AreEqual(ret, "IT");
        }
        [Test]
        public void Caculate_Multiple_3_5()
        {
            _starCorpProjectApplication = new StarCorpProjectApplication();
            var ret = _starCorpProjectApplication.Calculate(15);
            Assert.AreEqual(ret, "StarCorpianos");
        }
        [Test]
        public void Caculate_Type_Indefined()
        {
            _starCorpProjectApplication = new StarCorpProjectApplication();
            var ret = _starCorpProjectApplication.Calculate(121);
            Assert.AreEqual(ret, "Type Indefined");
        }

    }
}