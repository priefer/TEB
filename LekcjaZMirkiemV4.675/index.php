<?php

	session_start();

	if ((isset($_SESSION['zalogowany'])) && ($_SESSION['zalogowany']==true))
	{
		header('Location: gra.php');
		exit();
	}

?>

<!DOCTYPE HTML>
<html lang="pl">
<head>
	<meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<link rel="stylesheet" href="style.css">
	<script src='https://www.google.com/recaptcha/api.js'></script>
	<link rel="shortcut icon" type="image/x-icon" href="https://cdn2.iconfinder.com/data/icons/us-election-2020-illustrations/300/054-Pollution-2-512.png">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
	<title>Osadnicy - gra przeglądarkowa</title>
</head>

<body>
	<header>
		<p>Tylko martwi ujrzeli koniec wojny - Platon</p>
		<a href="rejestracja.php"><button id="rejestracjaBtn">Rejestracja</button></a>
	</header>
	<main>
		<div id="formRej">
			<form action="zaloguj.php" method="post">

				<p><br /> <input class="inp" type="text" placeholder="Login" autocomplete="off" name="login" /> <br /></p>
				<p><br /> <input class="inp" type="password" placeholder="Hasło" name="haslo" /> <br /><br /></p>
				<div id="recaptchaContainer" style="transform:scale(1.2);transform-origin:0 0">
				<div class="g-recaptcha" data-sitekey="6Lcl-c8ZAAAAACmMRaoYE2e7h9z8mJIrXmn-08aj"></div>
				</div>

				<?php
					if (isset($_SESSION['e_bot']))
					{
						echo '<div class="error">'.$_SESSION['e_bot'].'</div>';
						unset($_SESSION['e_bot']);
					}
				?>
				<br>
				<input id="sub" type="submit" value="Zaloguj się" />

			</form>
			
		</div>

	</main>



<?php
	if(isset($_SESSION['blad']))	echo $_SESSION['blad'];
?>

</body>
</html>
