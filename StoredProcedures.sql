--Bunlar sizi ilgilendirmiyor, bir þeyler denedim silmek istemedim.
SELECT 
	d.ID AS ID, d.DonorName, d.DonorAge, d.DonorPhone, d.DonorAddress, 
	bg.BloodGroup AS BGN, bg.ID AS BGID, 
	g.Gender AS GN, 
	b.BloodStock AS BS FROM tblDonor d 
		JOIN tblBloodGroup bg ON d.DonorBloodGroupID = bg.ID 
		JOIN tblBlood b ON bg.ID = b.BloodGroupID 
		JOIN tblGender g ON d.DonorGenderID = g.ID 
			Where DonorStatus = 1

------------------------------------------------------------------------------------

Select * From tblTransfer

------------------------------------------------------------------------------------

SELECT 
	tblTransfer.ID as ID,
    tblDonor.DonorName as DN,
    tblBloodGroup.BloodGroup as BG,
    tblTransfer.TransferBloodAmount as BA, tblTransfer.TransferDate DT, tblTransfer.TransferStatus as TS FROM tblTransfer
		INNER JOIN tblDonor ON tblTransfer.TransferDonorID = tblDonor.ID
		INNER JOIN tblBloodGroup ON tblTransfer.TransferBloodGroupID = tblBloodGroup.ID 
			WHERE tblTransfer.TransferStatus = 1

------------------------------------------------------------------------------------

SELECT 
	tblTransfer.ID,
    tblDonor.DonorName,
    tblBloodGroup.BloodGroup,
    tblTransfer.TransferBloodAmount, tblTransfer.TransferDate, tblTransfer.TransferStatus FROM tblTransfer
		INNER JOIN tblDonor ON tblTransfer.TransferDonorID = tblDonor.ID
		INNER JOIN tblBloodGroup ON tblTransfer.TransferBloodGroupID = tblBloodGroup.ID 
			WHERE tblTransfer.TransferStatus = 0

------------------------------------------------------------------------------------
--Bunlar sizin yapacaklarýnýz
CREATE PROCEDURE sp_GetTransfersByStatus_Active
AS
BEGIN
    SELECT 
        tblTransfer.ID AS ID,
        tblDonor.DonorName AS DN,
        tblBloodGroup.BloodGroup AS BG,
        tblTransfer.TransferBloodAmount AS BA,
        tblTransfer.TransferDate AS DT,
        tblTransfer.TransferStatus AS TS
    FROM 
        tblTransfer
    INNER JOIN 
        tblDonor ON tblTransfer.TransferDonorID = tblDonor.ID
    INNER JOIN 
        tblBloodGroup ON tblTransfer.TransferBloodGroupID = tblBloodGroup.ID
    WHERE 
        tblTransfer.TransferStatus = 1;
END;

------------------------------------------------------------------------------------

CREATE PROCEDURE sp_GetTransfersByStatus_Passive
AS
BEGIN
    SELECT 
        tblTransfer.ID AS ID,
        tblDonor.DonorName AS DN,
        tblBloodGroup.BloodGroup AS BG,
        tblTransfer.TransferBloodAmount AS BA,
        tblTransfer.TransferDate AS DT,
        tblTransfer.TransferStatus AS TS
    FROM 
        tblTransfer
    INNER JOIN 
        tblDonor ON tblTransfer.TransferDonorID = tblDonor.ID
    INNER JOIN 
        tblBloodGroup ON tblTransfer.TransferBloodGroupID = tblBloodGroup.ID
    WHERE 
        tblTransfer.TransferStatus = 0;
END;

------------------------------------------------------------------------------------

	