using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReverseItAPI.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItController : ControllerBase
    {
    [HttpGet]
    [Route("Reverse/{word}")]

    public string ReverseIt(string word)
    {
        char[] charArray = word.ToCharArray();
        string reversedInput = "";

        for (int i = charArray.Length - 1; i > -1; i--)
        {  
            reversedInput += charArray[i];
        }

        return reversedInput;
    }
    }
