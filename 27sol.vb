'write a program that accepts a year as input and outputs the century the year belongs in
'(e.g. 18th century's year ranges are 1701 to 1800) and whether or not the year is a leap year.

dim year as integer = inputbox("enter a year")
dim century as integer
dim leapyear as boolean = false

'find century of year
if year Mod 100 = 0 then
    century = (year/100)
else
    century = int((year/100)+1)
end if

'find if year is a leap year
if year Mod 4 <> 0 then
    leapyear = false
elseif year Mod 100 <> 0 then
    leapyear = true
elseif leapyear Mod 400 <> 0 then
    leapyear = false
else    
    leapyear = true
end if

msgbox("Century: " str(century)+ ", Leap year: " + str(leapyear))
