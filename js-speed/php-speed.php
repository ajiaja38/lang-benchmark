<?php
  $input = 2000000;

  $startTime = time();

  for ($i = 1; $i <= $input; $i++) {
    echo($i. "\n");
  }

  $endTime = time();
  $resultTime = $endTime - $startTime;

  echo "Result Time: " . $resultTime . "s";
?>