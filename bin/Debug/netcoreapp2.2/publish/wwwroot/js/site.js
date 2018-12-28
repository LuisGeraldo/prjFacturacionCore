// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(function(){

    // Modal
    $('#myModal').on('shown.bs.modal', function () {
       var articulo = $("select[name='articulos'] option:selected").text();
       console(articulo);
      
       

        $('#myInput').trigger('focus')
    });

    $("#btn-agregar-articulo").click(function(){
        var Cantidad = $("#Cantidad").val();
        var Articulo = 1;
       
        var valor = {
                        Cantidad: Cantidad,
                        IdArticulo: Articulo
                    };
        

        try{
            var url = "Agregar";

            $.post(url, valor).done(function(data){

                 $("#facturaSubTotal").text(data);
                
            }).fail(error).always(function(){

            });

            $("#Articulo-select").text(articulo);

            // $.ajax({ 
            //     url: '@Url.Action("UpdateOrder")', // to get the right path to controller from TableRoutes of Asp.Net MVC 
            //     dataType: "json", //to work with json format 
            //     type: "POST", //to do a post request 
            //     contentType: 'application/json; charset=utf-8', //define a contentType of your request 
            //     cache: false, //avoid caching results 
            //     data: JSON.stringify(valor), // here you can pass arguments to your request if you need 
            //     success: function (data) { 
            //      // data is your result from controller 
            //      if (data.success) { 
            //       alert(data.message); 
            //      }
            //    }
            // });

        }catch(err){
            
        }

    });

});

