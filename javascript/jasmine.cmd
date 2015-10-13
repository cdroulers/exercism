@IF EXIST "%~dp0\node.exe" (
  "%~dp0\node.exe" --debug "%APPDATA%\npm\node_modules\jasmine-node\bin\jasmine-node" --verbose %*
) ELSE (
  echo %*
  @SETLOCAL
  @SET PATHEXT=%PATHEXT:;.JS;=;%
  FOR %%G IN (*.spec.js) DO node  --debug --no-lazy "%APPDATA%\npm\node_modules\jasmine-node\bin\jasmine-node" --verbose %%G
)