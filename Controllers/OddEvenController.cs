//chris Martinez
//10/26/22
//Odd or Even Number End Point 
// https://localhost:****/OddEven/OddorEven/{numeros}
//Peer Review: The program takes mini challenge 7 and turns it into an API program. The user inputs a number and when it is typed into the url on Postman it tells you whether your number was odd or even. The program runs successfully and the code is formatted nice and neat. GOOD JOB!

using Microsoft.AspNetCore.Mvc;


namespace MartinezCOddEvenEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddEvenController : ControllerBase
{
 [HttpGet]
 [Route("OddOrEven/{numeros}")]
 public string OddOrEven(string numeros)
 {
  string result = "";
  int validNum = 0;
  bool breakout = Int32.TryParse(numeros, out validNum);
  //string myNum = $”{validNum} is an odd”;
  if (!breakout)
  {
   result = "Invalid Entry";
  }
  else if (validNum % 2 == 0)
  {
   result = $"{validNum} is an even number";
  }
  else
  {
   result = $"{validNum} is and odd number";
  }

  return result;
 }
}


