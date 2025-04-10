@echo off
echo ===========================================
echo     Deleting all bin / obj folders...
echo ===========================================

for /d /r %%d in (bin,obj) do (
    if exist "%%d" (
        echo Deleting : %%d
        rmdir /s /q "%%d"
    )
)

echo -------------------------------------------
