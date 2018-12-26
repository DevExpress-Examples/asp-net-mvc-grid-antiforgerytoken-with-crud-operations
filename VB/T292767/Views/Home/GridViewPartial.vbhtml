@Html.DevExpress.GridView(Sub(settings)
                                   settings.Name = "GridView"
                                   settings.KeyFieldName = "ProductID"
                                   settings.CallbackRouteValues = New With {Key .Controller = "Home", .Action = "GridViewPartial"}
                                   settings.SettingsEditing.AddNewRowRouteValues = New With {Key .Controller = "Home", .Action = "GridViewAddNewPartial"}
                                   settings.SettingsEditing.UpdateRowRouteValues = New With {Key .Controller = "Home", .Action = "GridViewUpdatePartial"}
                                   settings.SettingsEditing.DeleteRowRouteValues = New With {Key .Controller = "Home", .Action = "GridViewDeletePartial"}

                                   settings.CommandColumn.Visible = True
                                   settings.CommandColumn.ShowEditButton = True
                                   settings.CommandColumn.ShowNewButton = True
                                   settings.CommandColumn.ShowDeleteButton = True

                                   settings.CommandColumn.SetHeaderCaptionTemplateContent(Sub(c)
                                                                                              ViewContext.Writer.Write(Html.AntiForgeryToken().ToHtmlString())
                                                                                              ViewContext.Writer.Write("#")
                                                                                          End Sub)

                                   settings.Columns.Add(Sub(column)
                                                            column.FieldName = "ProductID"
                                                        End Sub)

                                   settings.Columns.Add("ProductName")
                                   settings.Columns.Add("UnitPrice")
                                   settings.Columns.Add("UnitsOnOrder")
                               End Sub).Bind(Model).GetHtml()
