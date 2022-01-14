using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Runtime;
using System.IO;
using System;
using Amazon.S3.Util;
using System.Collections.Generic;
using Amazon.CognitoIdentity;
using Amazon;

public class AWSManager : MonoBehaviour
{




  private void Awake()
    {

        UnityInitializer.AttachToGameObject(this.gameObject);


        CognitoAWSCredentials credentials = new CognitoAWSCredentials(
        "us-east-1:6afff219-0978-43dc-9314-70dd4f14292f", // Identity Pool ID
        RegionEndpoint.USEast1 // Region
        );


        IAmazonS3 s3Client = new AmazonS3Client(< credentials >, RegionEndpoint.USEast1);

    }
}
