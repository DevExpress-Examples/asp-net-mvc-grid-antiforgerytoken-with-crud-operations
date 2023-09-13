<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T292767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid for ASP.NET MVC - How to use AntiForgeryToken with CRUD operations

The [Html.AntiForgeryToken](https://learn.microsoft.com/en-us/dotnet/api/system.web.mvc.htmlhelper.antiforgerytoken) method generates a hidden form field (anti-forgery token) that can be validated when the form is submitted. Call this method inside a DevExpress callback-aware extension to automatically send the token value through an extension callback.

## Implementation Details

In this example, the `Html.AntiForgeryToken` method is called in a [SetHeaderCaptionTemplateContent](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewSettings.SetHeaderCaptionTemplateContent(System.Action-DevExpress.Web.GridViewHeaderTemplateContainer-)) method handler.

```scharp
@Html.DevExpress().GridView(settings => {
    // ...
    settings.CommandColumn.SetHeaderCaptionTemplateContent(c => {  
        ViewContext.Writer.Write(Html.AntiForgeryToken().ToHtmlString());  
        ViewContext.Writer.Write("#");  
    });  
```
During CRUD operations, the grid sends the token through a callback. To check the value on the server, decorate the action method with the [ValidateAntiForgeryToken](https://learn.microsoft.com/en-us/dotnet/api/system.web.mvc.validateantiforgerytokenattribute) attribute.

```scharp
[ValidateAntiForgeryToken]  
public ActionResult GridViewAddNewPartial(Product product) {
    // ...
}  
[ValidateAntiForgeryToken]  
public ActionResult GridViewUpdatePartial(Product product) {
    // ...
}  
[ValidateAntiForgeryToken]  
public ActionResult GridViewDeletePartial(int productID) {
    // ...
}  
```

## Files to Review

* [HomeController.cs](./CS/T292767/Controllers/HomeController.cs)
* [GridViewPartial.cshtml](./CS/T292767/Views/Home/GridViewPartial.cshtml)

## More Examples 
* [How to use AntiForgeryToken during DevExpress callbacks](https://github.com/DevExpress-Examples/how-to-use-antiforgerytoken-during-devexpress-callbacks-e5112)

