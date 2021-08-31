using SHCM_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SHCM_API.Controllers
{
    public class ProductsController : ApiController
    {
        private SHCMEntities db = new SHCMEntities();

        [HttpGet]
        public IHttpActionResult GetAllProduct()
        {
            return Ok(db.Products.ToList());
        }

        [HttpGet]
        public IHttpActionResult GetProductDetail(int id)
        {
            Product product = db.Products.SingleOrDefault(p => p.No == id);
            if (product == null)
            {
                //return Ok(new Product());
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult AddProduct(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Ok(new Message(0, "Thêm sản phẩm không thành công. Vui lòng thử lại"));
                }

                db.Products.Add(product);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return Ok(new Message(0, "Thêm sản phẩm không thành công. Vui lòng thử lại"));
            }
          
            return Ok(new Message(1, "Thêm sản phẩm thành công"));
        }
    }
}
