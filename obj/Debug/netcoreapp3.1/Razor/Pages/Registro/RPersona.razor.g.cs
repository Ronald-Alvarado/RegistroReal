#pragma checksum "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04870b7c40cad80d974c8f0767beec13b45286b"
// <auto-generated/>
#pragma warning disable 1591
namespace RegistroReal.Pages.Registro
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using RegistroReal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using RegistroReal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using RegistroReal.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\RONALD\source\BlazorApp\RegistroReal\_Imports.razor"
using RegistroReal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Persona")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Persona/{PersonaId:int}")]
    public partial class RPersona : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                 persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                         Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h3>Registro de Personas</h3>\r\n        </div>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n                 ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.AddMarkupContent(25, "<label>Persona Id</label>\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateInputNumber_0(__builder2, 29, 30, "form-control col-4", 31, 
#nullable restore
#line 21 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                                          persona.PersonaId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.PersonaId = __value, persona.PersonaId)), 33, () => persona.PersonaId);
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "input-group-append");
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "type", "button");
                __builder2.AddAttribute(40, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(42, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.AddMarkupContent(52, "<label>Nombres</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                            persona.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Nombre = __value, persona.Nombre))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateValidationMessage_1(__builder2, 59, 60, 
#nullable restore
#line 34 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                              () => persona.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.AddMarkupContent(66, "<label>Teléfono</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                            persona.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Telefono = __value, persona.Telefono))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.Telefono));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateValidationMessage_2(__builder2, 73, 74, 
#nullable restore
#line 42 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                              () => persona.Telefono

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.AddMarkupContent(80, "<label>Cédula</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                            persona.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Cedula = __value, persona.Cedula))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.Cedula));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateValidationMessage_3(__builder2, 87, 88, 
#nullable restore
#line 49 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                              () => persona.Cedula

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.AddMarkupContent(94, "<label>Dirección</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(95);
                __builder2.AddAttribute(96, "class", "form-control");
                __builder2.AddAttribute(97, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                            persona.Direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Direccion = __value, persona.Direccion))));
                __builder2.AddAttribute(99, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.Direccion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n                    ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateValidationMessage_4(__builder2, 101, 102, 
#nullable restore
#line 56 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                              () => persona.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                \r\n                ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "form-group");
                __builder2.AddMarkupContent(107, "\r\n                    ");
                __builder2.AddMarkupContent(108, "<label>Fecha Nacimiento</label>\r\n                    ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateInputDate_5(__builder2, 109, 110, "form-control", 111, 
#nullable restore
#line 62 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                            persona.FechaNacimiento

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.FechaNacimiento = __value, persona.FechaNacimiento)), 113, () => persona.FechaNacimiento);
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __Blazor.RegistroReal.Pages.Registro.RPersona.TypeInference.CreateValidationMessage_6(__builder2, 115, 116, 
#nullable restore
#line 63 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                              () => persona.FechaNacimiento

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(117, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n         ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "card-footer");
                __builder2.AddMarkupContent(123, "\r\n             ");
                __builder2.OpenElement(124, "table");
                __builder2.AddAttribute(125, "class", "table");
                __builder2.AddAttribute(126, "display:", true);
                __builder2.AddAttribute(127, "inline-block", true);
                __builder2.AddMarkupContent(128, "\r\n                 ");
                __builder2.OpenElement(129, "tr");
                __builder2.AddMarkupContent(130, "\r\n                     ");
                __builder2.OpenElement(131, "th");
                __builder2.AddMarkupContent(132, "\r\n                        ");
                __builder2.OpenElement(133, "button");
                __builder2.AddAttribute(134, "type", "button");
                __builder2.AddAttribute(135, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                                                                       Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(137, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                     ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                     ");
                __builder2.AddMarkupContent(140, "<th>\r\n                        <button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\r\n                     </th>\r\n                     ");
                __builder2.OpenElement(141, "th");
                __builder2.AddMarkupContent(142, "\r\n                        ");
                __builder2.OpenElement(143, "button");
                __builder2.AddAttribute(144, "type", "button");
                __builder2.AddAttribute(145, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
                                                                                      Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(147, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n                     ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                 ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n             ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\RONALD\source\BlazorApp\RegistroReal\Pages\Registro\RPersona.razor"
 
    private Persona persona = new Persona();

    [Parameter] public int PersonaId { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        persona.FechaNacimiento = DateTime.Now;
        Buscar();
    }

    private void Nuevo()
    {
        persona = new Persona();
        persona.FechaNacimiento = DateTime.Now;
    }

    private void Guardar()
    {
         bool guardado;

        guardado = PersonaBLL.Guardar(persona);

        if (guardado)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
            toast.ShowError("No fue posible guardar");
    }

    private void Buscar()
    {
         if (persona.PersonaId > 0)
         {
             var encontrado = PersonaBLL.Buscar(persona.PersonaId);
             if (encontrado != null)
                 persona = encontrado;
             else
                 toast.ShowWarning("La persona no fue encontrado");
         }       
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = PersonaBLL.Eliminar(persona.PersonaId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Persona eliminada correctamente");
        }
        else
            toast.ShowError("No fue posible eliminarla persona");     
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
namespace __Blazor.RegistroReal.Pages.Registro.RPersona
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591