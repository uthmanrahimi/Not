# What is MakeNot?
`Not` is a small and lightweight library based on .NET Standard. `Not` provides some extention methods for different built-in types.
> By using Not we no longer need to use `!` operator in our code.


# Install via NuGet

To install MakeNot, run the following comman in the Package Manager Console .

`Install-Package MakeNot`

Use following namespace :

    using Not;
# Usage and Methods

### 1-Boolean
Over boolean data type, `Not` extention method is avaialbe and can be used like :

    var result =  DoSomething()// return a boolean 
    if (result.Not())
    {
    // do something
    }


Wait! we have more for you.

### 2-String
Over string data type, there are two well-known and most used methods(`IsNullOrEmpty` and `IsNullOrWhiteSpace`) which help us to check string variables are null or empty.
Sometimes programmer use condition like these :

    string data = "";
    if (!string.IsNullOrEmpty( data) || !string.IsNullOrWhiteSpace(data))
    {
    //do sth
    }
        
By using `Not` you can rewrite above code and make it more readable like this:

    string data = "";
    if (data.IsNotNullOrEmpty() || data.IsNotNullOrWhiteSpace())
    {
    //do sth
    }

### 3-ModelState
If you are developing Web Application, No doubt, validating input data is one of the basic action we always do and most of the time we use a code like below :

     if (!ModelState.IsValid) 
     {
     return View(model);// 
     }

so we can rewrite it like :


    [HttpPost]
    public ActionResult Post(AddUserViewModel model)
    {
       if (ModelState.IsNotValid())
       {
         return BadRequest();
       }
       //do sth
    }

