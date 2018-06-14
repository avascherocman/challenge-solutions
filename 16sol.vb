Dim string1 as string = 'add string in here
Dim string2 as string = 'add other string in here. must contain a space
Dim i as integer, j as integer, k as integer

For i = 0 to len(string2)
    For j = 0 to len(string1) then
        if mid(string1, j, 1) = mid(string2, i, 1) then
            For k = j to len(string1)
                mid(string1, k, 1) = mid(string1, k+1, 1)
            Next k
        End if
    Next j
Next i 

msgbox(string1)
