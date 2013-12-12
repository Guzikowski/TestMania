using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookCatalogService.Process;
using IBookCatalogService.Data;
using IBookCatalogService.Domain;
using IBookCatalogService.Process;
using NUnit.Framework;
using Rhino.Mocks;
namespace TestBookCatalogService
{
    [TestFixture]
    public class AAATestClass : AutoMockerBase<FetchBookProcess>
    {
        [Test]
        public void Can_Fetch_By_Index()
        {
            //Arrange
            IBookDetail detailStub = MockRepository.GenerateStub<IBookDetail>();
            detailStub.Id = 454545;
            AutoMocker.Get<IBookDataManager>().Expect(x=>x.FetchBookByIndex(Arg<int>.Is.Anything)).Return(detailStub);
            int index = 2;
           
            //Act
            var actual = ClassUnderTest.FetchByIndex(index);

            //Assert
            Assert.AreEqual(detailStub.Id , actual.Id);
            AutoMocker.Get<IBookDataManager>().AssertWasCalled(x => x.FetchBookByIndex(Arg<int>.Is.Anything));
        }
   }
}
