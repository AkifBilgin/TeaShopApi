﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtoLayer.DrinkDtos;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly IDrinkService _drinkService;

        public DrinksController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        [HttpGet]
        public IActionResult DrinkList()
        {
            var values = _drinkService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDrink(CreateDrinkDto createDrinkDto)
        {
            Drink drink = new Drink()
            {
                DrinkImageUrl = createDrinkDto.DrinkImageUrl,
                DrinkName = createDrinkDto.DrinkName,
                DrinkPrice = createDrinkDto.DrinkPrice,
            };
            _drinkService.TInsert(drink);
            return Ok("Getränk erfolgreich hinzugefügt");
        }

        [HttpDelete]
        public IActionResult DeleteDrink(int id)
        {
          var valueToDelete =  _drinkService.TGetById(id);
            _drinkService.TDelete(valueToDelete);
            return Ok("Getränk wurde gelöscht");
        }

        [HttpGet("{id}")]
        public IActionResult GetDrinkByID(int id) 
        {
           var value = _drinkService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDrink(UpdateDrinkDto updateDrinkDto)
        {
            Drink drink = new Drink()
            {
                DrinkID = updateDrinkDto.DrinkID,
                DrinkImageUrl = updateDrinkDto.DrinkImageUrl,
                DrinkName = updateDrinkDto.DrinkName,
                DrinkPrice = updateDrinkDto.DrinkPrice,
            };
            _drinkService.TUpdate(drink);
            return Ok("Getränk wurde aktualisiert");
        }
    }
}
