Insert into Champions (ChampionId, ChampionName, ChampionImage)
SELECT '121', 'Zyra', BulkColumn
FROM Openrowset( Bulk 'C:\Users\Lucas\Documents\GitHub\StatMaster\project\StatMaster\StatMaster\Images\Champions\Zyra.png', single_blob) as img