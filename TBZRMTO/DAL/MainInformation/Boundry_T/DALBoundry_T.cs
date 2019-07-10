using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.BoundryDAL
{
class DALBoundry_T: DataLayerBase
{

public DALBoundry_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.BoundryBLL.BLLBoundry_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryID_int =new SqlParameter();
BoundryID_int.ParameterName = "@BoundryID_int";
BoundryID_int.SqlDbType = SqlDbType.Int;
BoundryID_int.Direction = ParameterDirection.Output;
BoundryID_int.IsNullable = false;
BoundryID_int.Value = businessObject.BoundryID_int;
this.Command.Parameters.Add(BoundryID_int);

SqlParameter BoundryCode_nvc =new SqlParameter();
BoundryCode_nvc.ParameterName = "@BoundryCode_nvc";
BoundryCode_nvc.SqlDbType = SqlDbType.NVarChar;
BoundryCode_nvc.Direction = ParameterDirection.Input;
BoundryCode_nvc.IsNullable = false;
BoundryCode_nvc.Value = businessObject.BoundryCode_nvc;
this.Command.Parameters.Add(BoundryCode_nvc);

SqlParameter Boundry_nvc =new SqlParameter();
Boundry_nvc.ParameterName = "@Boundry_nvc";
Boundry_nvc.SqlDbType = SqlDbType.NVarChar;
Boundry_nvc.Direction = ParameterDirection.Input;
Boundry_nvc.IsNullable = false;
Boundry_nvc.Value = businessObject.Boundry_nvc;
this.Command.Parameters.Add(Boundry_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.BoundryID_int = (Int32)(this.Command.Parameters["@BoundryID_int"].Value); 

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

public void Update(HPS.BLL.BoundryBLL.BLLBoundry_T businessObject,HPS.BLL.BoundryBLL.BLLBoundry_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryCode_nvc =new SqlParameter();
BoundryCode_nvc.ParameterName = "@BoundryCode_nvc";
BoundryCode_nvc.SqlDbType = SqlDbType.NVarChar;
BoundryCode_nvc.Direction = ParameterDirection.Input;
BoundryCode_nvc.IsNullable = false;
BoundryCode_nvc.Value = businessObject.BoundryCode_nvc;
this.Command.Parameters.Add(BoundryCode_nvc);

SqlParameter Boundry_nvc =new SqlParameter();
Boundry_nvc.ParameterName = "@Boundry_nvc";
Boundry_nvc.SqlDbType = SqlDbType.NVarChar;
Boundry_nvc.Direction = ParameterDirection.Input;
Boundry_nvc.IsNullable = false;
Boundry_nvc.Value = businessObject.Boundry_nvc;
this.Command.Parameters.Add(Boundry_nvc);


SqlParameter pk_BoundryID_int =new SqlParameter();
pk_BoundryID_int.ParameterName = "@pk_BoundryID_int";
pk_BoundryID_int.SqlDbType = SqlDbType.Int;
pk_BoundryID_int.Direction = ParameterDirection.Input;
pk_BoundryID_int.IsNullable = false;
pk_BoundryID_int.Value = businessObjectKey.BoundryID_int;
this.Command.Parameters.Add(pk_BoundryID_int);



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

public List< HPS.BLL.BoundryBLL.BLLBoundry_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.BoundryBLL.BLLBoundry_T> Result  =new  List< HPS.BLL.BoundryBLL.BLLBoundry_T>();
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
this.Command.CommandText = "[sp_Boundry_T_SelectAll]";
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
this.Command.CommandText = "[sp_Boundry_T_SelectAll]";
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
this.Command.CommandText = "[sp_Boundry_T_SelectAll]";
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

public HPS.BLL.BoundryBLL.BLLBoundry_T SelectByPrimaryKey(HPS.BLL.BoundryBLL.BLLBoundry_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryID_int =new SqlParameter();
BoundryID_int.ParameterName = "@BoundryID_int";
BoundryID_int.SqlDbType = SqlDbType.Int;
BoundryID_int.Direction = ParameterDirection.Input;
BoundryID_int.IsNullable = false;
BoundryID_int.Value = businessObjectKey.BoundryID_int;
this.Command.Parameters.Add(BoundryID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.BoundryBLL.BLLBoundry_T businessObject=new HPS.BLL.BoundryBLL.BLLBoundry_T();
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

public void SelectByPrimaryKey(HPS.BLL.BoundryBLL.BLLBoundry_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Boundry_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryID_int =new SqlParameter();
BoundryID_int.ParameterName = "@BoundryID_int";
BoundryID_int.SqlDbType = SqlDbType.Int;
BoundryID_int.Direction = ParameterDirection.Input;
BoundryID_int.IsNullable = false;
BoundryID_int.Value = businessObjectKey.BoundryID_int;
this.Command.Parameters.Add(BoundryID_int);


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

public void SelectByPrimaryKey(HPS.BLL.BoundryBLL.BLLBoundry_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Boundry_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryID_int =new SqlParameter();
BoundryID_int.ParameterName = "@BoundryID_int";
BoundryID_int.SqlDbType = SqlDbType.Int;
BoundryID_int.Direction = ParameterDirection.Input;
BoundryID_int.IsNullable = false;
BoundryID_int.Value = businessObjectKey.BoundryID_int;
this.Command.Parameters.Add(BoundryID_int);


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

public void SelectByPrimaryKey(HPS.BLL.BoundryBLL.BLLBoundry_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Boundry_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryID_int =new SqlParameter();
BoundryID_int.ParameterName = "@BoundryID_int";
BoundryID_int.SqlDbType = SqlDbType.Int;
BoundryID_int.Direction = ParameterDirection.Input;
BoundryID_int.IsNullable = false;
BoundryID_int.Value = businessObjectKey.BoundryID_int;
this.Command.Parameters.Add(BoundryID_int);



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





public List< HPS.BLL.BoundryBLL.BLLBoundry_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[Boundry_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.BoundryBLL.BLLBoundry_T> Result = new List< HPS.BLL.BoundryBLL.BLLBoundry_T>();
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
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Boundry_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Boundry_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Boundry_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.BoundryBLL.BLLBoundry_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.BoundryBLL.BLLBoundry_T> Result= new List<HPS.BLL.BoundryBLL.BLLBoundry_T>();
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
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
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
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
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
this.Command.CommandText = "[sp_Boundry_T_SelectCondition]";
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

public void Delete(HPS.BLL.BoundryBLL.BLLBoundry_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Boundry_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BoundryID_int =new SqlParameter();
BoundryID_int.ParameterName = "@BoundryID_int";
BoundryID_int.SqlDbType = SqlDbType.Int;
BoundryID_int.Direction = ParameterDirection.Input;
BoundryID_int.IsNullable = false;
BoundryID_int.Value = businessObjectKey.BoundryID_int;
this.Command.Parameters.Add(BoundryID_int);


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
this.Command.CommandText = "[sp_Boundry_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.BoundryBLL.BLLBoundry_T businessObject,IDataReader dataReader){
businessObject.BoundryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryID_int.ToString()));
businessObject.BoundryCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryCode_nvc.ToString()));
businessObject.Boundry_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.Boundry_nvc.ToString()));
}

public List< HPS.BLL.BoundryBLL.BLLBoundry_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.BoundryBLL.BLLBoundry_T> list=new List< HPS.BLL.BoundryBLL.BLLBoundry_T>();
while (dataReader.Read()){
HPS.BLL.BoundryBLL.BLLBoundry_T businessObject =new HPS.BLL.BoundryBLL.BLLBoundry_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 