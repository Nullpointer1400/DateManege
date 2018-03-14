<?php
//Unix timestampを取得
$timestamp=time();
//date()で日時を取得
$Year=date("Y",$timestamp);
$Month=date("n",$timestamp);
$Day=date("d",$timestamp);
$Hour=date("H",$timestamp);
$Minute=date("i",$timestamp);
$Second=date("s",$timestamp);
//配列に変換
$ary=array('Year'=>$Year,'Month'=>$Month,'Day'=>$Day,'Hour'=>$Hour,'Minute'=>$Minute,'Second'=>$Second);
//Jsonに変換し、echoで出力
$json = json_encode($ary);
echo $json;
?>