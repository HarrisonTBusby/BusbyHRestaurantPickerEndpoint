//Harrison Busby
//10/27/2022
//Restaurant Picker Endpoint
//Peer reviewed by:Marcel R. - The program runs exceptionally well with limited code. 
//Makes use of arrays and sets strings equal to the random number generated based on asian, fast food, or sit down. 
//I liked the choices and awesome work! :)



using Microsoft.AspNetCore.Mvc;

namespace BusbyHRestaurantPickerEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    
[HttpGet]
[Route("Restaurant/{foodType}")]

public string Food(string foodType){

string [] Asian = {"Pho King", "Golden Dragon", "China Palace", "Jade Lantern", "Golden Star"};
Random asianRan = new Random();

string [] FastFood = {"In and Out", "Arby's", "Burger King", "Jack in the Box", "Carl's Jr."};
Random fastFoodRan = new Random();

string[] SitDown = {"Denny's", "Black Bear Diner", "Bj's", "Cheesecake Factory", "C.R. Gibbs"};
Random sitDownRan = new Random();

if(foodType == "Asian"){

    int asianFood = asianRan.Next(0,5);
    foodType = Asian[asianFood];
}else if(foodType == "Fast Food"){

    int fastFood = fastFoodRan.Next(0,5);
    foodType = FastFood[fastFood];
}else if(foodType == "Sit Down"){

    int sitDown = sitDownRan.Next(0,5);
    foodType = SitDown[sitDown];
}

return $"You decided {foodType}";




}



}
