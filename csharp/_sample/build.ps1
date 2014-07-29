cp ..\packages\NUnit.2.6.3\lib\nunit.framework.dll nunit.framework.dll
csc.bat /t:library /out:Out.dll /r:.\nunit.framework.dll *.cs
