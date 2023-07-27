using System;

using R5T.T0141;


namespace R5T.S0092
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_DropboxDirectoryPath()
        {
            var dropboxDirectoryPath = Instances.DropboxDirectoryPathOperator.Get_DropboxDirectoryPath();

            Console.WriteLine(dropboxDirectoryPath);
        }
    }
}
