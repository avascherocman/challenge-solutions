'The population count of a bitstring is the number of set bits (1-bits) in the string.
' For instance, the population count of the number 23, which is represented in binary as 10111 is 4.
'Your task is to write a function that determines the population count of a number representing a bitstring
 
dim newBitString as string = MsgBox("Enter a bitstring") 'I can add bin conversion if necessary
dim popCount as integer = 0

dim i as integer 
for i = 1 to len(newBitString) 
    if mid(newBitString, i , 1) ="1" then
        popCount += 1
    end if
next i
