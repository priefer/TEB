<?php
session_start();

require_once 'database.php';

if (!isset($_SESSION['logged_id'])) {

	if (isset($_POST['login'])) {
		
		$login = filter_input(INPUT_POST, 'login');
		$password = filter_input(INPUT_POST, 'pass');
		
		$userQuery = $db->prepare('SELECT id, password FROM admins WHERE login = :login');
		$userQuery->bindValue(':login', $login, PDO::PARAM_STR);
		$userQuery->execute();
		
		$user = $userQuery->fetch();
		
		if ($user && password_verify($password, $user['password'])) {
			$_SESSION['logged_id'] = $user['id'];
			unset($_SESSION['bad_attempt']);
		} else {
			$_SESSION['bad_attempt'] = true;
			header('Location: admin.php');
			exit();
		}
			
	} else {
		
		header('Location: admin.php');
		exit();
	}
}

$usersQuery = $db->query('SELECT * FROM users');
$users = $usersQuery->fetchAll();

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
            <h1>Newsletter</h1>
        </header>

        <main>
            <article>
			
				<table>
					<thead>
						<tr><th colspan="2">Łącznie rekordów: <?= $usersQuery->rowCount() ?></th></tr>
						<tr><th>ID</th><th>E-mail</th></tr>
					</thead>
					<tbody>
						<?php
						foreach ($users as $user) {
							echo "<tr><td>{$user['id']}</td><td>{$user['email']}</td></tr>";
						}
						?>
					</tbody>
				</table>
				
				<p><a href="logout.php">Wyloguj się!</a></p>
				
            </article>
        </main>

    </div>

</body>
</html>