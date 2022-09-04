# TuringTermite
## Usage
1. Create txt file with rules for termite (Rule MUST contain A 0 condition).
2. Launch a programm.
3. Load rules from txt file.
4. You can export image by using export button.

## User interface
![image](https://user-images.githubusercontent.com/49571325/188317601-68a9559b-ee2b-4062-b3ea-6b0e2e2f291f.png)
## Rules samples

### Island
```
A 0 1 -1 B
A 1 2 -1 B
A 2 3 -1 B
A 3 4 -1 B
A 4 5 1 B
A 5 6 1 B
A 6 7 1 B
A 7 8 1 B
A 8 9 -1 B
A 9 10 -1 B
A 10 11 -1 B
A 11 12 -1 B
A 12 13 1 B
A 13 14 1 B
A 14 15 1 B
A 15 0 1 A
B 0 1 1 B
B 1 2 1 A
B 2 3 1 A
B 3 4 1 A
B 4 5 -1 A
B 5 6 -1 A
B 6 7 -1 A
B 7 8 -1 A
B 8 9 1 A
B 9 10 1 A
B 10 11 1 A
B 11 12 1 A
B 12 13 -1 A
B 13 14 -1 A
B 14 15 -1 A
B 15 0 -1 A
```

### Maze
```
A 0 1 -1 A 
A 1 2 -1 A 
A 2 3 -1 A 
A 3 4 -1 A 
A 4 5 -1 A 
A 5 6 1 B 
B 0 1 1 A 
B 5 6 -1 B 
B 6 7 -1 B 
B 7 8 -1 B 
B 8 9 -1 B 
B 9 10 -1 B 
B 10 11 -1 B 
B 11 12 -1 B 
B 12 13 -1 B 
B 13 14 -1 B 
B 14 15 -1 B 
B 15 0 -1 B
```
### Square
```
A 0 14 0 B
B 0 14 0 C
C 0 14 0 E
E 0 14 0 F
F 0 14 0 J
J 0 13 -1 A
A 14 13 0 A
A 13 14 0 A
J 14 13 0 A
J 13 14 1 A
```
