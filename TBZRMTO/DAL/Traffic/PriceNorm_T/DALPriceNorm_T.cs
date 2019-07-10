using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.PriceNormDAL
{
class DALPriceNorm_T: DataLayerBase
{

public DALPriceNorm_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.PriceNormBLL.BLLPriceNorm_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PriceNormID_int =new SqlParameter();
PriceNormID_int.ParameterName = "@PriceNormID_int";
PriceNormID_int.SqlDbType = SqlDbType.Int;
PriceNormID_int.Direction = ParameterDirection.Output;
PriceNormID_int.IsNullable = false;
PriceNormID_int.Value = businessObject.PriceNormID_int;
this.Command.Parameters.Add(PriceNormID_int);

SqlParameter CityID_int =new SqlParameter();
CityID_int.ParameterName = "@CityID_int";
CityID_int.SqlDbType = SqlDbType.Int;
CityID_int.Direction = ParameterDirection.Input;
CityID_int.IsNullable = false;
CityID_int.Value = businessObject.CityID_int;
this.Command.Parameters.Add(CityID_int);

SqlParameter LaderTypeID_int =new SqlParameter();
LaderTypeID_int.ParameterName = "@LaderTypeID_int";
LaderTypeID_int.SqlDbType = SqlDbType.Int;
LaderTypeID_int.Direction = ParameterDirection.Input;
LaderTypeID_int.IsNullable = false;
LaderTypeID_int.Value = businessObject.LaderTypeID_int;
this.Command.Parameters.Add(LaderTypeID_int);

SqlParameter GoodID_int =new SqlParameter();
GoodID_int.ParameterName = "@GoodID_int";
GoodID_int.SqlDbType = SqlDbType.Int;
GoodID_int.Direction = ParameterDirection.Input;
GoodID_int.IsNullable = true;
if(businessObject.GoodID_int.HasValue == false ){
GoodID_int.Value = DBNull.Value;
}else{
GoodID_int.Value = businessObject.GoodID_int;
}
this.Command.Parameters.Add(GoodID_int);

SqlParameter Price_dec =new SqlParameter();
Price_dec.ParameterName = "@Price_dec";
Price_dec.SqlDbType = SqlDbType.Decimal;
Price_dec.Direction = ParameterDirection.Input;
Price_dec.IsNullable = true;
if(businessObject.Price_dec.HasValue == false ){
Price_dec.Value = DBNull.Value;
}else{
Price_dec.Value = businessObject.Price_dec;
}
this.Command.Parameters.Add(Price_dec);

SqlParameter OldPrice_dec =new SqlParameter();
OldPrice_dec.ParameterName = "@OldPrice_dec";
OldPrice_dec.SqlDbType = SqlDbType.Decimal;
OldPrice_dec.Direction = ParameterDirection.Input;
OldPrice_dec.IsNullable = true;
if(businessObject.OldPrice_dec.HasValue == false ){
OldPrice_dec.Value = DBNull.Value;
}else{
OldPrice_dec.Value = businessObject.OldPrice_dec;
}
this.Command.Parameters.Add(OldPrice_dec);

SqlParameter CreateDate_nvc =new SqlParameter();
CreateDate_nvc.ParameterName = "@CreateDate_nvc";
CreateDate_nvc.SqlDbType = SqlDbType.NVarChar;
CreateDate_nvc.Direction = ParameterDirection.Input;
CreateDate_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.CreateDate_nvc) ){
CreateDate_nvc.Value = DBNull.Value;
}else{
CreateDate_nvc.Value = businessObject.CreateDate_nvc;
}
this.Command.Parameters.Add(CreateDate_nvc);

SqlParameter UpdateDate_nvc =new SqlParameter();
UpdateDate_nvc.ParameterName = "@UpdateDate_nvc";
UpdateDate_nvc.SqlDbType = SqlDbType.NVarChar;
UpdateDate_nvc.Direction = ParameterDirection.Input;
UpdateDate_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.UpdateDate_nvc) ){
UpdateDate_nvc.Value = DBNull.Value;
}else{
UpdateDate_nvc.Value = businessObject.UpdateDate_nvc;
}
this.Command.Parameters.Add(UpdateDate_nvc);

SqlParameter OriginCityID_int =new SqlParameter();
OriginCityID_int.ParameterName = "@OriginCityID_int";
OriginCityID_int.SqlDbType = SqlDbType.Int;
OriginCityID_int.Direction = ParameterDirection.Input;
OriginCityID_int.IsNullable = true;
if(businessObject.OriginCityID_int.HasValue == false ){
OriginCityID_int.Value = DBNull.Value;
}else{
OriginCityID_int.Value = businessObject.OriginCityID_int;
}
this.Command.Parameters.Add(OriginCityID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.PriceNormID_int = (Int32)(this.Command.Parameters["@PriceNormID_int"].Value); 

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

public void Update(HPS.BLL.PriceNormBLL.BLLPriceNorm_T businessObject,HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CityID_int =new SqlParameter();
CityID_int.ParameterName = "@CityID_int";
CityID_int.SqlDbType = SqlDbType.Int;
CityID_int.Direction = ParameterDirection.Input;
CityID_int.IsNullable = false;
CityID_int.Value = businessObject.CityID_int;
this.Command.Parameters.Add(CityID_int);

SqlParameter LaderTypeID_int =new SqlParameter();
LaderTypeID_int.ParameterName = "@LaderTypeID_int";
LaderTypeID_int.SqlDbType = SqlDbType.Int;
LaderTypeID_int.Direction = ParameterDirection.Input;
LaderTypeID_int.IsNullable = false;
LaderTypeID_int.Value = businessObject.LaderTypeID_int;
this.Command.Parameters.Add(LaderTypeID_int);

SqlParameter GoodID_int =new SqlParameter();
GoodID_int.ParameterName = "@GoodID_int";
GoodID_int.SqlDbType = SqlDbType.Int;
GoodID_int.Direction = ParameterDirection.Input;
GoodID_int.IsNullable = false;
if(businessObject.GoodID_int.HasValue == false ){
GoodID_int.Value = DBNull.Value;
}else{
GoodID_int.Value = businessObject.GoodID_int;
}
this.Command.Parameters.Add(GoodID_int);

SqlParameter Price_dec =new SqlParameter();
Price_dec.ParameterName = "@Price_dec";
Price_dec.SqlDbType = SqlDbType.Decimal;
Price_dec.Direction = ParameterDirection.Input;
Price_dec.IsNullable = true;
if(businessObject.Price_dec.HasValue == false ){
Price_dec.Value = DBNull.Value;
}else{
Price_dec.Value = businessObject.Price_dec;
}
this.Command.Parameters.Add(Price_dec);

SqlParameter OldPrice_dec =new SqlParameter();
OldPrice_dec.ParameterName = "@OldPrice_dec";
OldPrice_dec.SqlDbType = SqlDbType.Decimal;
OldPrice_dec.Direction = ParameterDirection.Input;
OldPrice_dec.IsNullable = true;
if(businessObject.OldPrice_dec.HasValue == false ){
OldPrice_dec.Value = DBNull.Value;
}else{
OldPrice_dec.Value = businessObject.OldPrice_dec;
}
this.Command.Parameters.Add(OldPrice_dec);

SqlParameter CreateDate_nvc =new SqlParameter();
CreateDate_nvc.ParameterName = "@CreateDate_nvc";
CreateDate_nvc.SqlDbType = SqlDbType.NVarChar;
CreateDate_nvc.Direction = ParameterDirection.Input;
CreateDate_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.CreateDate_nvc) ){
CreateDate_nvc.Value = DBNull.Value;
}else{
CreateDate_nvc.Value = businessObject.CreateDate_nvc;
}
this.Command.Parameters.Add(CreateDate_nvc);

SqlParameter UpdateDate_nvc =new SqlParameter();
UpdateDate_nvc.ParameterName = "@UpdateDate_nvc";
UpdateDate_nvc.SqlDbType = SqlDbType.NVarChar;
UpdateDate_nvc.Direction = ParameterDirection.Input;
UpdateDate_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.UpdateDate_nvc) ){
UpdateDate_nvc.Value = DBNull.Value;
}else{
UpdateDate_nvc.Value = businessObject.UpdateDate_nvc;
}
this.Command.Parameters.Add(UpdateDate_nvc);

SqlParameter OriginCityID_int =new SqlParameter();
OriginCityID_int.ParameterName = "@OriginCityID_int";
OriginCityID_int.SqlDbType = SqlDbType.Int;
OriginCityID_int.Direction = ParameterDirection.Input;
OriginCityID_int.IsNullable = true;
if(businessObject.OriginCityID_int.HasValue == false ){
OriginCityID_int.Value = DBNull.Value;
}else{
OriginCityID_int.Value = businessObject.OriginCityID_int;
}
this.Command.Parameters.Add(OriginCityID_int);


SqlParameter pk_PriceNormID_int =new SqlParameter();
pk_PriceNormID_int.ParameterName = "@pk_PriceNormID_int";
pk_PriceNormID_int.SqlDbType = SqlDbType.Int;
pk_PriceNormID_int.Direction = ParameterDirection.Input;
pk_PriceNormID_int.IsNullable = false;
pk_PriceNormID_int.Value = businessObjectKey.PriceNormID_int;
this.Command.Parameters.Add(pk_PriceNormID_int);



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

public List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T> Result  =new  List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T>();
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectAll]";
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectAll]";
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectAll]";
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

public HPS.BLL.PriceNormBLL.BLLPriceNorm_T SelectByPrimaryKey(HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PriceNormID_int =new SqlParameter();
PriceNormID_int.ParameterName = "@PriceNormID_int";
PriceNormID_int.SqlDbType = SqlDbType.Int;
PriceNormID_int.Direction = ParameterDirection.Input;
PriceNormID_int.IsNullable = false;
PriceNormID_int.Value = businessObjectKey.PriceNormID_int;
this.Command.Parameters.Add(PriceNormID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.PriceNormBLL.BLLPriceNorm_T businessObject=new HPS.BLL.PriceNormBLL.BLLPriceNorm_T();
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

public void SelectByPrimaryKey(HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_PriceNorm_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PriceNormID_int =new SqlParameter();
PriceNormID_int.ParameterName = "@PriceNormID_int";
PriceNormID_int.SqlDbType = SqlDbType.Int;
PriceNormID_int.Direction = ParameterDirection.Input;
PriceNormID_int.IsNullable = false;
PriceNormID_int.Value = businessObjectKey.PriceNormID_int;
this.Command.Parameters.Add(PriceNormID_int);


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

public void SelectByPrimaryKey(HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_PriceNorm_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PriceNormID_int =new SqlParameter();
PriceNormID_int.ParameterName = "@PriceNormID_int";
PriceNormID_int.SqlDbType = SqlDbType.Int;
PriceNormID_int.Direction = ParameterDirection.Input;
PriceNormID_int.IsNullable = false;
PriceNormID_int.Value = businessObjectKey.PriceNormID_int;
this.Command.Parameters.Add(PriceNormID_int);


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

public void SelectByPrimaryKey(HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_PriceNorm_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PriceNormID_int =new SqlParameter();
PriceNormID_int.ParameterName = "@PriceNormID_int";
PriceNormID_int.SqlDbType = SqlDbType.Int;
PriceNormID_int.Direction = ParameterDirection.Input;
PriceNormID_int.IsNullable = false;
PriceNormID_int.Value = businessObjectKey.PriceNormID_int;
this.Command.Parameters.Add(PriceNormID_int);



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





public List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[PriceNorm_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T> Result = new List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T>();
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[PriceNorm_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[PriceNorm_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[PriceNorm_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.PriceNormBLL.BLLPriceNorm_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.PriceNormBLL.BLLPriceNorm_T> Result= new List<HPS.BLL.PriceNormBLL.BLLPriceNorm_T>();
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
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
this.Command.CommandText = "[sp_PriceNorm_T_SelectCondition]";
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

public void Delete(HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PriceNorm_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PriceNormID_int =new SqlParameter();
PriceNormID_int.ParameterName = "@PriceNormID_int";
PriceNormID_int.SqlDbType = SqlDbType.Int;
PriceNormID_int.Direction = ParameterDirection.Input;
PriceNormID_int.IsNullable = false;
PriceNormID_int.Value = businessObjectKey.PriceNormID_int;
this.Command.Parameters.Add(PriceNormID_int);


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
this.Command.CommandText = "[sp_PriceNorm_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.PriceNormBLL.BLLPriceNorm_T businessObject,IDataReader dataReader){
businessObject.PriceNormID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.PriceNormID_int.ToString()));
businessObject.CityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.CityID_int.ToString()));
businessObject.LaderTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.LaderTypeID_int.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.GoodID_int.ToString())) == false) {
businessObject.GoodID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.GoodID_int.ToString()));
}else{
businessObject.GoodID_int = null;
}

if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.Price_dec.ToString())) == false) {
businessObject.Price_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.Price_dec.ToString()));
}else{
businessObject.Price_dec = null;
}

if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.OldPrice_dec.ToString())) == false) {
businessObject.OldPrice_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.OldPrice_dec.ToString()));
}else{
businessObject.OldPrice_dec = null;
}

if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.CreateDate_nvc.ToString())) == false) {
businessObject.CreateDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.CreateDate_nvc.ToString()));
}else{
businessObject.CreateDate_nvc = String.Empty;
}

if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.UpdateDate_nvc.ToString())) == false) {
businessObject.UpdateDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.UpdateDate_nvc.ToString()));
}else{
businessObject.UpdateDate_nvc = String.Empty;
}

if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.OriginCityID_int.ToString())) == false) {
businessObject.OriginCityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PriceNormBLL.BLLPriceNorm_T.PriceNorm_TField.OriginCityID_int.ToString()));
}else{
businessObject.OriginCityID_int = null;
}

}

public List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T> list=new List< HPS.BLL.PriceNormBLL.BLLPriceNorm_T>();
while (dataReader.Read()){
HPS.BLL.PriceNormBLL.BLLPriceNorm_T businessObject =new HPS.BLL.PriceNormBLL.BLLPriceNorm_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 