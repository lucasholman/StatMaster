UPDATE Champions
set ChampionImage = BulkColumn
FROM Openrowset( Bulk 'C:\Users\Lucas\Documents\GitHub\StatMaster\project\StatMaster\StatMaster\Images\Champions\sona.png', single_blob) as img
WHERE ChampionId = 87;