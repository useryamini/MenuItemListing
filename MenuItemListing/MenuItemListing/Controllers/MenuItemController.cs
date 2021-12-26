using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    public class MenuItemController : Controller
    {
        List<MenuItem> menu;
        
        [HttpGet("id")]
        public IActionResult GetDetails(int id)
        {
            menu = new List<MenuItem>() {
            new MenuItem()
            {
                Id = 1001,
                Name = "ChickenCurry",
                freeDelivery = true,
                Price = 300,
                DateOfLaunch = Convert.ToDateTime("2021-12-26"),
                Active = true


            },

            new MenuItem()
            {
                Id = 1002,
                Name = "VegMixedCurry",
                freeDelivery = false,
                Price = 350,
                DateOfLaunch = Convert.ToDateTime("2021-12-26"),
                Active = true

            }
            };

           var MenuItems = menu.FirstOrDefault(x => x.Id == id);
            return Ok(MenuItems);

        }
     
            
     }
 }

