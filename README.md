# algorithmic-complexity
The challenge outline for this repository can be found [here](https://github.com/makersacademy/course/tree/master/algorithmic_complexity).

## Todo
- [ ] Set up Environment
- [ ] Create a testing function


## Testing Function

Pseudo code for how I anticipate this working

```
Test(FunctionToBeTested(), MaxArraySize, incrementSize, NoTimesTestsRepeated){
  results = new Hash
  i = 0 + incrementSize
  n = 1  

  for (n; while n <= NoTimesTestsRepeated; n++){

    results[i] = new Array

    for (i; while i<= MaxArraySize; i += incrementSize){
      testArray = setup(i)

      var startTime = time.now

      FunctionToBeTested(testArray)

      var timeTaken = time.now - startTime

      results[i] << timeTaken

      tearDown()
    }  
  }

}

setup(arraySize){
  return array(1... arraySize).shuffle
}

tearDown(){
  # If there is anything that needs tearing down after each test it would be handled here
  # possible clear memory?
}
```

Results Hash will resemble the below prior to averaging or removing upper and lower bounds
```
Results {
  10 => {
    0.02, 0.03, 0.02
  }
  20 => {
    0.02, 0.03, 0.02
  }
  30 => {
    0.02, 0.03, 0.02
  }
}
```
