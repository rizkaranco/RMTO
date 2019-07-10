using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.InfractionSurveyGroupDAL
{
class DALInfractionSurveyGroup_T: DataLayerBase
{

public DALInfractionSurveyGroup_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Output;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObject.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);

SqlParameter InfractionSurveyGroup_nvc =new SqlParameter();
InfractionSurveyGroup_nvc.ParameterName = "@InfractionSurveyGroup_nvc";
InfractionSurveyGroup_nvc.SqlDbType = SqlDbType.NVarChar;
InfractionSurveyGroup_nvc.Direction = ParameterDirection.Input;
InfractionSurveyGroup_nvc.IsNullable = false;
InfractionSurveyGroup_nvc.Value = businessObject.InfractionSurveyGroup_nvc;
this.Command.Parameters.Add(InfractionSurveyGroup_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.InfractionSurveyGroupID_int = (Int32?)(this.Command.Parameters["@InfractionSurveyGroupID_int"].Value);

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void Update(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T businessObject,HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroup_nvc =new SqlParameter();
InfractionSurveyGroup_nvc.ParameterName = "@InfractionSurveyGroup_nvc";
InfractionSurveyGroup_nvc.SqlDbType = SqlDbType.NVarChar;
InfractionSurveyGroup_nvc.Direction = ParameterDirection.Input;
InfractionSurveyGroup_nvc.IsNullable = false;
InfractionSurveyGroup_nvc.Value = businessObject.InfractionSurveyGroup_nvc;
this.Command.Parameters.Add(InfractionSurveyGroup_nvc);


SqlParameter pk_InfractionSurveyGroupID_int =new SqlParameter();
pk_InfractionSurveyGroupID_int.ParameterName = "@pk_InfractionSurveyGroupID_int";
pk_InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
pk_InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
pk_InfractionSurveyGroupID_int.IsNullable = false;
pk_InfractionSurveyGroupID_int.Value = businessObjectKey.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(pk_InfractionSurveyGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> Result  =new  List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset,String srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T SelectByPrimaryKey(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObjectKey.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T businessObject=new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T();
if(dataReader.Read()) {
PopulateBusinessObjectFromReader(businessObject, dataReader);
}else{
businessObject = null;
}

if(dataReader.IsClosed == false) {
dataReader.Close();
}


if(ControlConnection) {
this.Commit();
}
return businessObject;}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObjectKey.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObjectKey.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObjectKey.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);



if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}





public List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> Result = new List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName ,Object  value  , ref System.Data.DataSet dataset  ,String  srcTable  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref System.Data.DataSet dataset  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public List<HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> Result= new List<HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataSet dataset,String srcTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  ,ref System.Data.DataSet dataset ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataTable dataTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void Delete(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObjectKey.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);


if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void DeleteByField(String fieldName,Object value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyGroup_T_DeleteByField]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
this.Command.Parameters.Add(new SqlParameter("@Value", value));

if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void PopulateBusinessObjectFromReader(  HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T businessObject,IDataReader dataReader){
businessObject.InfractionSurveyGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString()));
businessObject.InfractionSurveyGroup_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroup_nvc.ToString()));
}

public List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T> list=new List< HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T>();
while (dataReader.Read()){
HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T businessObject =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 