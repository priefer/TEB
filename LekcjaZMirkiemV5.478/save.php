<?php

session_start();

if (isset($_POST['email'])) {
	
	$email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
	
	if (empty($email)) {
		
		$_SESSION['given_email'] = $_POST['email'];
		header('Location: index.php');
		
	} else {
		
		require_once 'database.php';
		
		$query = $db->prepare('INSERT INTO users VALUES (NULL, :email)');
		$query->bindValue(':email', $email, PDO::PARAM_STR);
		$query->execute();
	}
	
	
} else {
	
	header('Location: index.php');
	exit();
}

?>
<!DOCTYPE html>
<html lang="pl">
<head>

    <meta charset="utf-8">
    <title>Zapisanie się do newslettera</title>
    <link rel="stylesheet" href="main.css">


</head>

<body>
    <div id='stars'></div>
    <div id='stars2'></div>
    <div id='stars3'></div>
    <div class="container">

        <header>
            <h1>Newsletter</h1>
        </header>

        <main>
            <article>
                <p>Dziękujemy za zapisanie się na listę mailową naszego newslettera!</p>
            </article>
        </main>

    </div>

</body>
</html>