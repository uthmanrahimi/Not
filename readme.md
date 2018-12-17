<b>Not</b> Is a Library based on .NET Core .

It provides some extension methods that make easy to apply `!` on  variables . With <b>Not</b> you do not need to use `!` in your code .


# Boolean
instead of following code 

``` 
if (!validationResult.Successed)
            {
                //do somethis
            }
```
with <b>Not</b> you change code like this :


``` if (!validationResult.Successed)
            {
                //do somethis
            }```
            
# String

            
# ModelState
one of the extension methods that <b>Not</b> provides is for `ModelStateDictionary` . with <b>Not</b> you can validate you model like this :
```
[HttpPost]
        public ActionResult Post(AddUserViewModel model)
        {
            if (ModelState.IsNotValid())
            {
                return BadRequest();
            }
            //do sth
        }

```
