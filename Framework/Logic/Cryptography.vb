Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports DevExpress.Compression

Namespace Logic


    Public Class Cryptography

        Public Shared Function ComputeHash(ByVal plainText As String, ByVal hashAlgorithm As String, Optional ByVal saltBytes() As Byte = Nothing) As String
            ' If salt is not specified, generate it on the fly.
            If (saltBytes Is Nothing) Then

                ' Define min and max salt sizes.
                Const minSaltSize As Integer = 4
                Const maxSaltSize As Integer = 8

                ' Generate a random number for the size of the salt.
                Dim random As Random = New Random()

                Dim saltSize As Integer = random.Next(minSaltSize, maxSaltSize)

                ' Allocate a byte array, which will hold the salt.
                saltBytes = New Byte(saltSize - 1) {}

                ' Initialize a random number generator.
                Dim rng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()

                ' Fill the salt with cryptographically strong byte values.
                rng.GetNonZeroBytes(saltBytes)
            End If

            ' Convert plain text into a byte array.
            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)

            ' Allocate array, which will hold plain text and salt.
            Dim plainTextWithSaltBytes() As Byte =
            New Byte(plainTextBytes.Length + saltBytes.Length - 1) {}

            ' Copy plain text bytes into resulting array.
            Dim I As Integer
            For I = 0 To plainTextBytes.Length - 1
                plainTextWithSaltBytes(I) = plainTextBytes(I)
            Next I

            ' Append salt bytes to the resulting array.
            For I = 0 To saltBytes.Length - 1
                plainTextWithSaltBytes(plainTextBytes.Length + I) = saltBytes(I)
            Next I

            ' Because we support multiple hashing algorithms, we must define
            ' hash object as a common (abstract) base class. We will specify the
            ' actual hashing algorithm class later during object creation.
            Dim hash As HashAlgorithm

            ' Make sure hashing algorithm name is specified.
            If (hashAlgorithm Is Nothing) Then
                hashAlgorithm = ""
            End If

            ' Initialize appropriate hashing algorithm class.
            Select Case hashAlgorithm.ToUpper()

                Case "SHA1"
                    hash = New SHA1Managed()

                Case "SHA256"
                    hash = New SHA256Managed()

                Case "SHA384"
                    hash = New SHA384Managed()

                Case "SHA512"
                    hash = New SHA512Managed()

                Case Else
                    hash = New MD5CryptoServiceProvider()

            End Select

            ' Compute hash value of our plain text with appended salt.
            Dim hashBytes As Byte() = hash.ComputeHash(plainTextWithSaltBytes)

            ' Create array which will hold hash and original salt bytes.
            Dim hashWithSaltBytes() As Byte =
                                   New Byte(hashBytes.Length +
                                            saltBytes.Length - 1) {}

            ' Copy hash bytes into resulting array.
            For I = 0 To hashBytes.Length - 1
                hashWithSaltBytes(I) = hashBytes(I)
            Next I

            ' Append salt bytes to the result.
            For I = 0 To saltBytes.Length - 1
                hashWithSaltBytes(hashBytes.Length + I) = saltBytes(I)
            Next I

            ' Convert result into a base64-encoded string.
            Dim hashValue As String = Convert.ToBase64String(hashWithSaltBytes)

            ' Return the result.
            ComputeHash = hashValue
        End Function

        Public Shared Function VerifyHash(ByVal plainText As String, ByVal hashAlgorithm As String, ByVal hashValue As String) As Boolean

            ' Convert base64-encoded hash value into a byte array.
            Dim hashWithSaltBytes As Byte() = Convert.FromBase64String(hashValue)

            ' We must know size of hash (without salt).
            Dim hashSizeInBits As Integer
            Dim hashSizeInBytes As Integer

            ' Make sure that hashing algorithm name is specified.
            If (hashAlgorithm Is Nothing) Then
                hashAlgorithm = ""
            End If

            ' Size of hash is based on the specified algorithm.
            Select Case hashAlgorithm.ToUpper()
                Case "SHA1"
                    hashSizeInBits = 160
                Case "SHA256"
                    hashSizeInBits = 256
                Case "SHA384"
                    hashSizeInBits = 384
                Case "SHA512"
                    hashSizeInBits = 512
                Case Else ' Must be MD5
                    hashSizeInBits = 128
            End Select

            ' Convert size of hash from bits to bytes.
            hashSizeInBytes = hashSizeInBits / 8

            ' Make sure that the specified hash value is long enough.
            If (hashWithSaltBytes.Length < hashSizeInBytes) Then
                VerifyHash = False
            End If

            ' Allocate array to hold original salt bytes retrieved from hash.
            Dim saltBytes() As Byte = New Byte(hashWithSaltBytes.Length - hashSizeInBytes - 1) {}

            ' Copy salt from the end of the hash to the new array.
            Dim I As Integer
            For I = 0 To saltBytes.Length - 1
                saltBytes(I) = hashWithSaltBytes(hashSizeInBytes + I)
            Next I

            ' Compute a new hash string.
            Dim expectedHashString As String = ComputeHash(plainText, hashAlgorithm, saltBytes)

            ' If the computed hash matches the specified hash,
            ' the plain text value must be correct.
            VerifyHash = (hashValue = expectedHashString)
        End Function

        Public Shared Sub CompressFile(fileName As String)
            Dim encryptionType As EncryptionType = EncryptionType.PkZip
            Dim zipFilename As String = String.Format("{0}.zip", Path.GetFileNameWithoutExtension(fileName))
            Using archive As New ZipArchive()
                archive.EncryptionType = encryptionType
                archive.AddFile(fileName, "/")
                archive.Save(String.Format("{0}\{1}", Path.GetDirectoryName(fileName), zipFilename))
            End Using
        End Sub
    End Class
End Namespace