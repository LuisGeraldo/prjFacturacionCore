$(document).ready(function(){

    var articulo = [];

    $('#myModal').on('shown.bs.modal', function () {
        $('#myInput').trigger('focus');
    });

    //Modal para agregar articulos
    $("#ModalAgregar").click(function(){
        $("#Articulo-select").text($("select[name=ArticuloCombo] option:selected").text());
    });

    //Crear cliente
    $("#btn-agregar-cliente").click(function(){
        var url = "/Cliente/Create";
        $("#btn-agregar-cliente").prop('disabled', true);
        $(".loader").css({"display": "block"});

            try{
                var Nombre = $("#Nombre").val();
                var Apellido = $("#Apellido").val();
                var Cedula = $("#Cedula").val();

                if(Nombre == "" || Apellido == "" || Cedula == ""){
                    errorMessage("Todos los campos son requeridos!");
                    $(".loader").css({"display": "none"});
                    $("#btn-agregar-cliente").prop('disabled', false);
                }else{

                    var valores = {
                        Nombre : Nombre,
                        Apellido : Apellido,
                        Cedula : Cedula
                    }
    
                    $.post(url, valores).done(valores =>{
                        $(".loader").css({"display": "none"});
                        successMessage("Cliente registrado con exito", "Se registro el cliente sin inconvenientes", " href='javascript:location.reload()'", "Listo!");
                    });
                }

            }catch(error){
                console.log(error);
            }
    });

    //Funcion para agregar articulos al array
    function enterToArray(Cantidad,  IdArticulo, NombreArticulo){
        var valor = {
            "Cantidad": Cantidad,
            "IdArticulo": IdArticulo,
            "NombreArticulo": NombreArticulo
         }
         articulo.unshift(valor);
    }
         
    //Funcion para llenar la tabla de articulos
    function LlenarTable(){
        $("#detalle-table tr").remove();
    
        articulo.forEach(function(element, index) { 
           var fila = '<tr  data-index="'+index+'">'
            +'<td >'
                +(index + 1)
            +'</td>'

            +'<td id="Articulo">' 
                +element.NombreArticulo 
            +'</td>'

            +'<td>'
                +element.Cantidad
            +'</td>'

            +'<td>'
                +'<input type="button"  class="btn bg-danger text-white" value="Eliminar" id="remove" />'
            +'</td>'
       +'</tr>';

        $("#detalle-table").append(fila);   
       
        });
    }

    //Evento click para eliminar un articulo
    $(document).on('click', '#remove', function (event) { 
        event.preventDefault(); 
        var index = $(this).closest('tr').data('index');
        articulo.splice(index, 1);
        LlenarTable();
    });
    

    $("#agregar").click(function(){ 
        var Cantidad = $("#Cantidad").val();
        var IdArticulo = $("select[name=ArticuloCombo] option:selected").val();
        var NombreArticulo = $("select[name=ArticuloCombo] option:selected").text();

        if(Cantidad <= 0){
            errorMessage("La cantidad de articulos no es valida");
        }else{
            enterToArray(Cantidad, IdArticulo, NombreArticulo);
        }

        LlenarTable();
    });

    
    $("#btn-enviar-factura").click(function(){
        if(articulo.length <= 0)
            errorMessage("Debes agregar por lo menos un articulo para poder realizar la factura");   
        else{

        $("#btn-enviar-factura").prop('disabled', true);
        $(".loader").css({"display": "block"});
        var url = "Agregar";
        var IdCliente = $("select[name=IdCliente] option:selected").val();
        var IdCondicionPago = $("select[name=IdCondicionPago] option:selected").val();
        var IdEstado = $("select[name=IdEstado] option:selected").val();
        var Comentario = $("select[name=Comentario] option:selected").val();

        var Header = {
            IdCliente: IdCliente,
            IdCondicionPago: IdCondicionPago,
            IdEstado: IdEstado,
            Comentario: Comentario
        };
        
        var data = { 
            ArticulosValues: articulo, 
            FacturaHeader: Header 
        };

        $.post(url, data).done(function(data){
            $(".loader").css({"display": "none"});
              successMessage("Factura realizada con exito", "Se realizo la factura sin inconvenientes"," href='/Factura'" ,"Ver las factura!");

              $("#facturaSubTotal").text(data.subtotal);
              $("#facturaTotal").text(data.total);
            });
        }
    });

    $("#consultar").click(function(){
        $(".loader").css({"display": "block"});
        var IdArticulo = $("select[name=ArticuloCombo] option:selected").val();
        var NombreArticulo = $("select[name=ArticuloCombo] option:selected").text();
        var url = "Consultar";
        var data = {IdArticulo: IdArticulo}

        $.post(url, data).done(data =>{
            $(".loader").css({"display": "none"});

            Swal({
                title:'<strong>Articulo consulta</strong>',
                html: '<table class="table">'
                        +'<tr>'
                            +'<th>Articulo</th>'
                            +'<th>Precio</th>'
                            +'<th>Existencia</th>'
                        +'</tr>'
                        +'<tr>'
                            +'<td>'+NombreArticulo+'</td>'
                            +'<td>'+data.articulo.precioVenta+'</td>'
                            +'<td>'+data.articulo.existencia+'</td>'
                        +'</tr>'    
                     +'</table>'
        
            });
        });
    });

    function successMessage(title, message, action, actionText)
    {
        Swal({
            title: '<strong>'+title+'</strong>',
            type: 'success',
            html:  message,
            showCloseButton: true,
            showCancelButton: false,
            focusConfirm: false,
            confirmButtonText:
              '<i class="fa fa-thumbs-up"></i><a style="text-decoration: none; color: white" '+action+'  >'+actionText+'</a>'                
            });
    }

    function errorMessage(message)
    {
        Swal({
            type: 'error',
            title: 'Oops...',
            text: message,
            footer: '<a href>Sistema desarrollador Luis Geraldo</a>'
        });   
    }
});

