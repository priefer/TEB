<?php
session_start();

if (isset($_SESSION['logged_id'])) {
	header('Location: list.php');
	exit();
}
?>
<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="utf-8">
    <title>Panel administracyjny</title>

    <link rel="stylesheet" href="main.css">
</head>

<body>
    
    <div id='stars2'></div>
    <div id='stars3'></div>
    <div class="container">

        <header>
            <h1>Admin</h1>
        </header>

        <main>
            <article>
                <form method="post" action="list.php">
                    <label>Login <input type="text" name="login"></label>
                    <label>Hasło <input type="password" name="pass"></label>
                    <input type="submit" value="Zaloguj się!">
					
					<?php
					if (isset($_SESSION['bad_attempt'])) {
						echo '<p>Niepoprawny login lub hasło!</p>';
						unset($_SESSION['bad_attempt']);
					}
					?>
					
                </form>
            </article>
        </main>

    </div>
</body>
</html>