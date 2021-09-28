<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">
    <link rel="stylesheet" href="mainstyle.css">
    <title>user login</title>
</head>
<body>
<div class="container">
    <div class="row head" >
        <div class="jumbotron">
            <div class="container ">
                <div class="row">
                    <div class="col-1"><h3  class="display-4">🐱‍👤</h3></div>
                    <div class="col-11"><h3 class="display-4 ">Project </h3></div>
                </div>     
            </div>
        </div> 
    </div>

    
        <div class="row flex-sm-row flex-column-reverse">
            <div class="col-md-8 left">
            <br>    
            <h5>Hírek</h5> <br>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus condimentum, purus vel feugiat cursus, odio urna dapibus tellus, vel sagittis odio lectus vel purus. Proin elementum diam in tempor porttitor. Nunc in facilisis tellus. Mauris maximus felis mauris. Aliquam erat volutpat. Quisque non massa at mi pellentesque condimentum ac vel sapien. Nam varius dui non ultricies egestas. </p>

<p>Vivamus auctor vulputate ipsum, sed mollis augue efficitur sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Sed interdum massa vel nisi auctor, et malesuada erat sodales. In sit amet venenatis odio. Ut bibendum ex tempus tellus vehicula egestas. Proin dictum imperdiet nulla at gravida. Fusce pretium gravida gravida. </p>

<p>Etiam iaculis ex sapien, eu tristique tellus iaculis sit amet. Fusce cursus dolor ut magna congue lacinia. Proin sagittis, nibh sit amet accumsan gravida, justo metus fringilla tellus, eget dapibus quam mauris ut libero. Fusce ornare, ex sit amet cursus pharetra, mauris felis ullamcorper dui, quis placerat ex quam in nunc. Mauris vulputate leo vitae metus egestas pulvi nar. Etiam euismod velit arcu. Donec augue quam, blandit ac turpis id, dictum interdum urna. Fusce fermentum placerat dui luctus convallis. Quisque faucibus lectus ac nisi semper posuere. Curabitur aliquet velit ante, quis dignissim lacus commodo vel. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec hendrerit, dui at ornare sollicitudin, erat massa suscipit orci, quis cursus urna dui et purus. Pellentesque venenatis aliquet augue, non commodo ipsum vulputate at. </p>
            </div>
            <div class="col-md-4 right">
            <br>
            <h5 >Bejelentkezés/Regisztráció</h5>
            <?php
            switch(isset($_GET["id"]))
            {
                case  isset($_GET["id"]) && $_GET["id"]=='log' :
                    include('login.php');
                    break;

                case isset($_GET["id"]) && $_GET["id"]=='reg':
                include('reg.php');
                break;
            }

            ?>
            </div>
        </div>
        <div class="row foot" >
        <div class="jumbotron">
            <div class="container ">
            <h4 class="display-6 ">Footer</h4>
            </div>
        </div> 
    </div>
</div>
</body>
</html>
if(isset($_GET["id"]) && $_GET["id"]=='reg')
            {
                include('reg.php');
            }
            else{
            include('login.php');
            }