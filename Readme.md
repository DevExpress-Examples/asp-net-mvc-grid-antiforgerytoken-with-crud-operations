<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T292767/Controllers/HomeController.cs)
* [NorthwindDataProvider.cs](./CS/T292767/Models/NorthwindDataProvider.cs)
* [Product.cs](./CS/T292767/Models/Product.cs)
* [GridViewPartial.cshtml](./CS/T292767/Views/Home/GridViewPartial.cshtml)
* **[Index.cshtml](./CS/T292767/Views/Home/Index.cshtml)**
<!-- default file list end -->
# How to use AntiForgeryToken with GridView CRUD operations


This example is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18920">KA18920: How to use AntiForgeryToken during DevExpress callbacks</a> KB Article. Refer to the Article for an explanation.

<br/>

Note that starting with v15.1, our callback-aware extensions automatically collect values of nested input elements and send them through a callback.
So, it is no longer necessary to pass RequestVerificationToken as custom request data by handling the client-side BeginCallback event if AntiForgeryToken is rendered within extensions boundaries (for example, as a part of any template, etc.)
