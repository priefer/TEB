<?php

	session_start();

	if (!isset($_SESSION['zalogowany']))
	{
		header('Location: index.php');
		exit();
	}

?>
<!DOCTYPE HTML>
<html lang="pl">
<head>
	<meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<title>Osadnicy - gra przeglądarkowa</title>
	<link rel="stylesheet" href="style.css">
</head>

<body>
	<div id="gra">
		<div class="">
			<?php

				echo "<p>Witaj ".$_SESSION['user'].'! [ <a href="logout.php">Wyloguj się!</a> ]</p>';
				echo "<p><b>Drewno</b>: ".$_SESSION['drewno'];
				echo " | <b>Kamień</b>: ".$_SESSION['kamien'];
				echo " | <b>Zboże</b>: ".$_SESSION['zboze']."</p>";

				echo "<p><b>E-mail</b>: ".$_SESSION['email'];
				echo "<br /><b id='premium'></b></p>"
				/*echo "<br /><b>Premium wygaśnie za</b>: ".""."</p>";

				$dateA = new DateTime();
				$dateB =  DateTime::createFromFormat('Y-m-d H:i:s', $_SESSION['dnipremium']);
				$premium = $dateA->diff($dateB);
				
				if ($dateA < $dateB) {
				echo "<br /><b>Premium wygaśnie za</b>: ".$premium->format('%y lat, %m mies, %d dni, %h godz, %i min, %s sek')."</p>";
				}else{
					echo "<br /><b>Ni mosz premki</b></p>";
				}
				*/
			?>
		</div>

	</div>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	<script>
		$(document).ready(function() {
			$.post("premka.php",
			function (data, textStatus, jqXHR) {
				$("#premium").html(data);
			});
			setInterval(function(){ $.post("premka.php",
			function (data, textStatus, jqXHR) {
				$("#premium").html(data);
			}); }, 1000);
		
		});
	</script>
</body>
</html>
