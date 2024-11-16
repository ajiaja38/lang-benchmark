package main

import (
	"fmt"
	"time"
)

func main() {
	timeValue := time.Now()

	input := 2000000

	for i := 1; i <= input; i++ {
		fmt.Println(i)
	}

	resultTime := time.Since(timeValue)
	fmt.Printf("Result Time %v \n", resultTime)
}
