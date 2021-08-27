<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551914/18.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T292767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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
