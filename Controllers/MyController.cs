using CoreAPI2.Data;
using CoreAPI2.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ProductDb ProductdbObj;
        public MyController(ProductDb db)
        {
            ProductdbObj=db;
        }
        [HttpGet]
        public List<Product>GetAll()
        {
            List<Product> PList = ProductdbObj.Products.ToList();
            return PList;
        }

        

        [HttpPost]
        public IActionResult Post(Product pro1)
        {
            ProductdbObj.Products.Add(pro1);
            ProductdbObj.SaveChanges();
            return Ok(pro1);
        }

        [HttpPut]
        public IActionResult Put(Product pro1)
        {
            var NewDataForUpdate=ProductdbObj.Products.Find(pro1.Rec_Id);
            NewDataForUpdate.Name = pro1.Name;
            NewDataForUpdate.MobileNo = pro1.MobileNo;
            ProductdbObj.Products.Update(NewDataForUpdate);
            ProductdbObj.SaveChanges();
            return Ok(pro1);
        }

        [HttpDelete]
        public IActionResult Delete(Int64 id)
        {
            var NewDataForUpdate = ProductdbObj.Products.Find(id);
            ProductdbObj.Products.Remove(NewDataForUpdate);
            ProductdbObj.SaveChanges();
            return Ok();
        }

        [HttpGet("GetId/{Id}")]
        public IActionResult GetById(Int64 Id)
        {
            List<Product> PListById = ProductdbObj.Products.Where(x => x.Rec_Id == Id).ToList();
            
            return  Ok(PListById);
        }

    }
}
