
    $(document).ready(function () {

        $("#fecha").change(function () {
            var str = "";
            str += $(this).val();
            let arr = str.split('-');

            switch (arr[1]) {
                case "01":
                    var mes = arr[0] + "-01";
                    var anio = arr[0];
                    var mxy = "Enero " + arr[0];
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                case "02":
                    var mes = arr[0] + "-02";
                    var anio = arr[0];
                    var mxy = "Febrero " + arr[0];
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                case "03":
                    var anio = arr[0];
                    var mxy = "Marzo " + arr[0];
                    var mes = arr[0] + "-03";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                case "04":
                    var anio = arr[0];
                    var mxy = "Abril " + arr[0];
                    var mes = arr[0] + "-04";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#MxY").val(mxy);
                    $("#anio").val(anio);
                    break;
                case "05":
                    var mes = arr[0] + "-05";
                    var mxy = "Mayo " + arr[0];
                    var anio = arr[0];
                    $("#mesanio").val(mes);//2022-12-20
                    $("#MxY").val(mxy);
                    $("#anio").val(anio);
                    break;
                case "06":
                    var anio = arr[0];
                    var mxy = "Junio " + arr[0];
                    var mes = arr[0] + "-06";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#MxY").val(mxy);
                    $("#anio").val(anio);
                    break;
                case "07":
                    var anio = arr[0];
                    var mxy = "Julio " + arr[0];
                    var mes = arr[0] + "-07";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#MxY").val(mxy);
                    $("#anio").val(anio);
                    break;
                case "08":
                    var anio = arr[0];
                    var mxy = "Agosto " + arr[0];
                    var mes = arr[0] + "-08";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#MxY").val(mxy);
                    $("#anio").val(anio);
                    break;
                case "09":
                    var anio = arr[0];
                    var mxy = "Septiembre " + arr[0];
                    var mes = arr[0] + "-09";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                case "10":
                    var anio = arr[0];
                    var mxy = "Octubre " + arr[0];
                    var mes = arr[0] + "-10";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                case "11":
                    var anio = arr[0];
                    var mxy = "Noviembre " + arr[0];
                    var mes = arr[0] + "-11";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                case "12":
                    var anio = arr[0];
                    var mxy = "Diciembre " + arr[0];
                    var mes = arr[0] + "-12";
                    $("#mesanio").val(mes);//2022-12-20
                    $("#anio").val(anio);
                    $("#MxY").val(mxy);
                    break;
                default:
            }
        })
    });


