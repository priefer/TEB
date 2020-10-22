<?php 
	session_start();
    $dateA = new DateTime();
    $dateB =  DateTime::createFromFormat('Y-m-d H:i:s', $_SESSION['dnipremium']);
    $premium = $dateA->diff($dateB);

    if ($dateA < $dateB) {
        echo "<br /><b>Premium wygaśnie za</b>: ".$premium->format('%d dni, %h godz, %i min, %s sek')."</p>";
    }else{
        echo "<br /><b>Ni mosz premki</b></p>";
    }
?>