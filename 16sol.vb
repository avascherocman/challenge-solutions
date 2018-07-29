'Write a function that takes two strings and removes from the first string any character that appears in the second string. 
'For instance, if the first string is “Daily Programmer” and the second string is “aeiou ” the result is “DlyPrgrmmr”. 
'note: the second string has [space] so the space between "Daily Programmer" is removed

dim i as integer, j as integer, k as integer
dim str1 as string
dim str2 as string

for i = 1 to len(str2)
    for j = 1 to len(str1)
        if mid(str1, i, 1) = mid(str2, j, 1) then
            for k = j to len(str1)
                mid(str1, k, 1)=mid(str1, k+1, k)
            next k
        end if
    next j
next i
