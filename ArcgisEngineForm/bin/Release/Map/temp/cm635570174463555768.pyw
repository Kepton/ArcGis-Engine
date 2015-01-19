import arcpy
import os
import sys
reload(sys)   
sys.setdefaultencoding('utf8')

wrkspc = ur"D:\codes\Runtime\Workspace\admin\\"
service = ur"空白地图"
con = ur"D:\codes\Runtime\\Arcgis_Server_Admin.ags"

mxdName=wrkspc + service + '.mxd'
sd = wrkspc + service + '.sd'
sddraft = wrkspc + service + '.sddraft'
summary = 'the summary of ' + service + '.mxd'
tags = 'the tags of ' + service + '.mxd'
logName = wrkspc + 'temp\\' + service +'.log'

print logName

if os.path.exists(logName):
    os.remove(logName)
    print "delete logName success"

log=open(logName,'w')

if os.path.exists(sddraft):
    os.remove(sddraft)
    print "delete sddraft success"
    log.write( "delete sddraft success\n")
if os.path.exists(sd):
    os.remove(sd)
    print "delete sd success"
    log.write( "delete sd success\n")


mapDoc = arcpy.mapping.MapDocument(mxdName)
arcpy.mapping.CreateMapSDDraft(mapDoc, sddraft, service, 'ARCGIS_SERVER', con, True, None, summary, tags)
analysis = arcpy.mapping.AnalyzeForSD(sddraft)


for key in ('messages', 'warnings', 'errors'):
    log.write( "----" + key.upper() + "---\n")
    vars = analysis[key]
    for ((message, code), layerlist) in vars.iteritems():
        log.write(  "    " + message + " (CODE %i)" % code +"\n")
        log.write(  "applies to:\n")
        for layer in layerlist:
            log.write(  layer.name+"\n")
        

if analysis['errors'] == {}:
    arcpy.StageService_server(sddraft, sd)
    print "convert mxd file to sd file success\n"
    log.write( "convert mxd file to sd file success\n")   
else:
    print "Service could not be published because errors were found during analysis.\n"
    log.write("Service could not be published because errors were found during analysis.\n")
    
log.close()