using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class AcceptAllCertificatesSignedWithASpecificKeyPublicKey : CertificateHandler
    {
        // Fields
        private static string PUB_KEY;
        
        // Methods
        protected override bool ValidateCertificate(byte[] certificateData)
        {
            var val_6;
            System.Security.Cryptography.X509Certificates.X509Certificate2 val_1 = new System.Security.Cryptography.X509Certificates.X509Certificate2(rawData:  certificateData);
            string val_2 = GetPublicKeyString();
            string val_3 = ToLower();
            val_6 = null;
            val_6 = null;
            string val_4 = twelvegigs.Autopilot.AcceptAllCertificatesSignedWithASpecificKeyPublicKey.PUB_KEY.ToLower();
            bool val_5 = Equals(value:  twelvegigs.Autopilot.AcceptAllCertificatesSignedWithASpecificKeyPublicKey.PUB_KEY);
            return true;
        }
        public AcceptAllCertificatesSignedWithASpecificKeyPublicKey()
        {
        
        }
        private static AcceptAllCertificatesSignedWithASpecificKeyPublicKey()
        {
            twelvegigs.Autopilot.AcceptAllCertificatesSignedWithASpecificKeyPublicKey.PUB_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAuedpVthnAGyZLlM3zsWfuIMP3NNSmaPbL0xbHFMH/juouwkccEP+RlBEbsApUGU9LqB9AEPhYTNIr6Mw+nmBHZnuRJkwpcIhIYfooJfZ45yE2hVGU3pAmKH63AvO/aE1lDQA0AVPKyOIvDEva29sdM/v0IJ+0itIk0MLbEF0dkN6PXrclzeDZvutNwldBU65gP0fQCCE/NHnIgmx2U4muJ4rXaCygtsImTuP9cD6kQ7SGFRAnuK6wq5Wctx3+urFB3wVB45Hh4aDog3XF9Yh479jpdbeOLSRmiAnd8SsCSbKVNwZCXxPtc69T1LUDksZzVFBvqM1K5CpuJLp6y/C+wIDAQAB";
        }
    
    }

}
