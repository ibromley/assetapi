using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AssetApi.Models;
using Newtonsoft.Json;
using System.IO;

namespace AssetApi.Controllers
{
    [Route("api/[controller]")]
    public class AssetController : Controller
    {
        private readonly AssetContext _context;

        public AssetController(AssetContext context)
        {
            _context = context;

            if (_context.AssetItems.Count() == 0)
            {
                //_context.AssetItems.Add(new AssetItem { Name = "Asset1"});
                _context.SaveChanges();
            }
        }


        // GET api/asset
        [HttpGet]
        public IEnumerable<AssetItem> GetAll()
        {
            return _context.AssetItems.ToList();
        }
    }
}
