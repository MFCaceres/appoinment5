using HealthCon.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace NUnit_WebApi
    
{
    public class WebAPiTesting : ControllerBase
    {
        private readonly DocCareOnlineContext _context;

        public WebAPiTesting(DocCareOnlineContext context)
        {
            _context = context;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetReturn()
        {
            var 
            var result = _context.Countries.ToList();

            Assert.Pass();
        }
    }
}