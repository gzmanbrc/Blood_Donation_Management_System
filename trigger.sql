CREATE TRIGGER trg_UpdateTransferStatus
ON tblTransfer
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Tüm eski kayýtlarý kontrol et
    UPDATE t
    SET TransferStatus = 0
    FROM tblTransfer t
    WHERE DATEDIFF(DAY, t.TransferDate, GETDATE()) > 50 
      AND t.TransferStatus = 1;
END;
GO

Update tblTransfer Set TransferDonorID=1, TransferBloodGroupID=1, TransferBloodAmount=2, TransferDate='2023-10-10', TransferStatus=1 Where ID=14




