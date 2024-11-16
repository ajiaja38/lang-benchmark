import time

def python_speed(inputValue):
  timeValue = time.perf_counter()
  
  for i in range (inputValue):
    print(i)
    
  timeEnd = time.perf_counter()
  timeResult = timeEnd - timeValue
  
  print(f"Result: {timeResult:.6f} s")
    
inputValue = 2000000
python_speed(inputValue)